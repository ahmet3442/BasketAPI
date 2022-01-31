using Business.Abstract;
using Core.Common.Constant;
using Core.Common.Service;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;


namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        IOrderProductDal _orderProductDal;
        IProductService _productService;
        public OrderManager(IOrderDal orderDal, IOrderProductDal orderProductDal, IProductService productService)
        {
            _orderDal = orderDal;
            _orderProductDal = orderProductDal;
            _productService = productService;
        }
        public ResponseDto CreateOrder(BasketDto dto)
        {
            var response = new ResponseDto();
            bool isSaved;
            var order = new Order()
            {
                TotalPrice = dto.TotalPrice,
                TotalCampaignPrice = dto.TotalCampaignPrice,
                CreateUser = dto.UserId
            };
            _orderDal.Add(order);
            isSaved = _orderDal.SaveChanges();
            if(!isSaved)
                return Error.SaveError.JsonSerialize().JsonDeserialize<ResponseDto>();
            dto.OrderId = order.Id;
            response = CreateOrderProduct(dto);
            if (!response.IsSuccess)
                return response;

            response.Data = order;
            return response;
        }
        public ResponseDto CreateOrderProduct(BasketDto dto)
        {
            bool isSaved;
            var response = new ResponseDto();
            foreach (var item in dto.OrderItems)
            {
                var op = new OrderProduct()
                {
                   CampaignPrice=item.CampaingAmount,
                   OrderId=dto.OrderId,
                   Price=item.Amount,
                   ProductId=item.ProductId
                };
                _orderProductDal.Add(op);
                _productService.UpdateStock(item.ProductId, item.Count);
                
            }

            isSaved = _orderProductDal.SaveChanges();
            if (!isSaved)
                return Error.SaveError.JsonSerialize().JsonDeserialize<ResponseDto>();
           
            return response;
        }
    }
}
