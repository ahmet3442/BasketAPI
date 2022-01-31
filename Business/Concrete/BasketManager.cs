using Business.Abstract;
using Core.Cache;
using Core.Common.Constant;
using Core.Common.Service;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Definitions;
using Entity.DTOs;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BasketManager : IBasketService
    {
        IMemoryCache _memoryCache;
        IUserSessionService _userSession;
        IProductService _productService;
        IOrderService _orderService;
        Guid userid;
        public BasketManager(IMemoryCache memoryCache, IUserSessionService userSession, IBasketDal basketDal, IProductService productService, IOrderService orderService)
        {

            _memoryCache = memoryCache;
            _userSession = userSession;
            _productService = productService;
            _orderService = orderService;
            userid = new Guid(_userSession.GetUserId());
        }

        public async Task<ResponseDto> ConfirmBasket(CancellationToken cancellationToken)
        {
            ResponseDto response = new();

            response = await GetBasket(cancellationToken);
            if (!response.IsSuccess)
                return response;
            var basket = response.Data.JsonSerialize().JsonDeserialize<BasketDto>();

            response = CalculateConfirmBasket(basket);

            if (!response.IsSuccess)
                return response;
            response = _orderService.CreateOrder(basket);
            if (!response.IsSuccess)
                return response;


            DeleteBasket(cancellationToken);
            return response;
        }

        public async Task<ResponseDto> CreateBasket(CancellationToken cancellationToken)
        {
            var response = new ResponseDto();

            try
            {
                var key = CacheKey.Basket + userid;
                BasketDto cache = null;

                if (_memoryCache.TryGetValue(key, out cache))
                {
                    _memoryCache.Remove(key);
                    _memoryCache.Set<BasketDto>(key, cache);
                    response.Data = cache;
                    return response;
                }

                BasketDto basket = new(userid);
                response.Data = basket;

                _memoryCache.Set<BasketDto>(key, basket);

                return response;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ResponseDto> DeleteBasket(CancellationToken cancellationToken)
        {
            var response = new ResponseDto();
            try
            {
                var key = CacheKey.Basket + userid;
                BasketDto cache = null;

                if (_memoryCache.TryGetValue(key, out cache))
                {
                    _memoryCache.Remove(key);
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ResponseDto> GetBasket(CancellationToken cancellationToken)
        {
            var response = new ResponseDto();
            try
            {
                var key = CacheKey.Basket + userid;

                BasketDto cache = null;
                if (_memoryCache.TryGetValue(key, out cache))
                {
                    _memoryCache.Remove(key);
                    _memoryCache.Set<BasketDto>(key, cache);
                    response.Data = cache;
                }
                else
                    return Error.BasketNotFound.JsonSerialize().JsonDeserialize<ResponseDto>();

                return response;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<ResponseDto> UpdateBasket(UpdateBasketDto dto, CancellationToken cancellationToken)
        {
            ResponseDto response = new();
            var key = CacheKey.Basket + userid;
            BasketDto cache = null;

            if (_memoryCache.TryGetValue(key, out cache))
            {
                _memoryCache.Remove(key);
                _memoryCache.Set<BasketDto>(key, cache);
            }
            else
            {
                var addBasketResponse = await CreateBasket(cancellationToken);
                if (!addBasketResponse.IsSuccess)
                    return addBasketResponse;
                cache = addBasketResponse.Data.JsonSerialize().JsonDeserialize<BasketDto>();
            }

            if (dto.isAdd)
                response = CalculateAddBasket(cache, dto);
            else
                response = CalculateRemoveBasket(cache, dto);

            if (!response.IsSuccess)
                return response;

            _memoryCache.Remove(key);
            cache = response.Data.JsonSerialize().JsonDeserialize<BasketDto>();
            _memoryCache.Set<BasketDto>(key, cache);

            return response;
        }
        private ResponseDto CalculateAddBasket(BasketDto basket, UpdateBasketDto dto)
        {
            double price = 0;
            double campaignprice = 0;
            ResponseDto response = new();

            if (dto != null)
            {
                if (basket.OrderItems.Count == 0)
                {
                    basket.OrderItems.Add(new BasketItemDto()
                    {
                        ProductId = dto.ProductId,
                        Count = 0
                    });
                }
                else if (!basket.OrderItems.Where(p => p.ProductId == dto.ProductId).Any())
                {
                    basket.OrderItems.Add(new BasketItemDto()
                    {
                        ProductId = dto.ProductId,
                        Count = 0
                    });
                }
            }

            foreach (var item in basket.OrderItems)
            {
                if (item.ProductId == dto.ProductId)
                {
                    var count = item.Count + dto.Count;

                    response = _productService.ProductStockControl(item.ProductId, count);
                    if (!response.IsSuccess)
                        return response;

                    item.Count += dto.Count;

                    response = _productService.GetProductPrice(item.ProductId);
                    if (!response.IsSuccess)
                        return response;

                    price = response.Data.JsonSerialize().JsonDeserialize<double>();

                    basket.TotalPrice += price * dto.Count;
                    item.Amount = price;

                    response = _productService.GetProductPriceWithCampaign(item.ProductId);
                    if (!response.IsSuccess)
                        return response;

                    campaignprice = response.Data.JsonSerialize().JsonDeserialize<double>();
                    basket.TotalCampaignPrice += campaignprice * dto.Count;
                    item.CampaingAmount = campaignprice;
                }
            }

            response.Data = basket;
            return response;
        }
        private ResponseDto CalculateRemoveBasket(BasketDto basket, UpdateBasketDto dto)
        {
            double price = 0;
            double campaignprice = 0;
            ResponseDto response = new();

            foreach (var item in basket.OrderItems)
            {
                if (item.ProductId == dto.ProductId)
                {
                    if (dto.Count > item.Count)
                        item.Count = dto.Count;

                    item.Count -= dto.Count;

                    response = _productService.GetProductPrice(item.ProductId);
                    if (!response.IsSuccess)
                        return response;

                    price = response.Data.JsonSerialize().JsonDeserialize<double>();

                    basket.TotalPrice -= price * dto.Count;
                    item.Amount = price;

                    response = _productService.GetProductPriceWithCampaign(item.ProductId);
                    if (!response.IsSuccess)
                        return response;

                    campaignprice = response.Data.JsonSerialize().JsonDeserialize<double>();
                    basket.TotalCampaignPrice -= campaignprice * dto.Count;
                    item.CampaingAmount = campaignprice;

                }
            }
            basket.OrderItems.RemoveAll(l => l.Count == 0);

            response.Data = basket;
            return response;
        }
        private ResponseDto CalculateConfirmBasket(BasketDto basket)
        {

            double price = 0;
            double campaignprice = 0;
            ResponseDto response = new();

            basket.TotalPrice = 0;
            basket.TotalCampaignPrice = 0;
            foreach (var item in basket.OrderItems)
            {


                response = _productService.ProductStockControl(item.ProductId, item.Count);
                if (!response.IsSuccess)
                    return response;


                response = _productService.GetProductPrice(item.ProductId);
                if (!response.IsSuccess)
                    return response;

                price = response.Data.JsonSerialize().JsonDeserialize<double>();

                basket.TotalPrice += price * item.Count;
                item.Amount = price;

                response = _productService.GetProductPriceWithCampaign(item.ProductId);
                if (!response.IsSuccess)
                    return response;

                campaignprice = response.Data.JsonSerialize().JsonDeserialize<double>();
                basket.TotalCampaignPrice += campaignprice * item.Count;
                item.CampaingAmount = campaignprice;

            }

            response.Data = basket;
            return response;
        }
    }
}
