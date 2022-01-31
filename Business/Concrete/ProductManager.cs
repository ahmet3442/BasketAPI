using Business.Abstract;
using Core.Common.Constant;
using Core.Common.Service;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        IProductPriceDal _productPriceDal;
        ICampaignDal _campaignDal;
        public ProductManager(IProductDal productDal, IProductPriceDal productPriceDal, ICampaignDal campaignDal)
        {
            _productDal = productDal;
            _productPriceDal = productPriceDal;
            _campaignDal = campaignDal;
        }

        public ResponseDto GetProduct(Guid productId)
        {
            ResponseDto response = new();
            var product = _productDal.Get(p => p.Id == productId);
            if (product == null)
                return Error.ProductNotFound.JsonSerialize().JsonDeserialize<ResponseDto>();
            response.Data = product;
            return response;
        }
        public ResponseDto GetProductPrice(Guid productId)
        {
            ResponseDto response = new();
            response = GetProduct(productId);
            if (!response.IsSuccess)
                return response;

            var productPrice = _productPriceDal.Get(p => p.ProductId == productId && p.StartDate < DateTime.Now && p.EndDate > DateTime.Now);
            if (productPrice == null)
                return Error.ProductPricetNotFound.JsonSerialize().JsonDeserialize<ResponseDto>();
            response.Data = productPrice.Price;
            return response;
        }
        public ResponseDto GetProductPriceWithCampaign(Guid productId)
        {
            ResponseDto response = new();
            
            response = GetProduct(productId);
            if (!response.IsSuccess)
                return response;

            var productPriceResponse = GetProductPrice(productId);
            if (!productPriceResponse.IsSuccess)
                return productPriceResponse;

            var productPrice = productPriceResponse.Data.JsonSerialize().JsonDeserialize<double>();

            var campaigns = _campaignDal.GetList(c => c.ProductId == productId && c.StartDate < DateTime.Now && c.EndDate > DateTime.Now);

            if (campaigns == null)
                response.Data = productPrice;

            else
            {
                double amount = 0;
                foreach (var item in campaigns)
                {
                    if (item.CampaignType == Core.Common.Enums.CampaignType.DiscountAmount)
                    {
                        amount = productPrice - item.Discount;
                        if (amount < 0)
                            return Error.CampaignAmountError.JsonSerialize().JsonDeserialize<ResponseDto>();
                    }
                    if (item.CampaignType == Core.Common.Enums.CampaignType.DiscountRate)
                    {
                        amount = productPrice - (productPrice * item.Discount) / 100;
                    }
                }
                response.Data = amount;
            }
            return response;
        }
        public ResponseDto ProductStockControl(Guid productId,int count)
        {
            ResponseDto response = new();

            response = GetProduct(productId);
            if (!response.IsSuccess)
                return response;

            var product = response.Data.JsonSerialize().JsonDeserialize<Product>();
            if(count>product.Stock)
                return Error.StockNotEnough.JsonSerialize().JsonDeserialize<ResponseDto>();

            return response;

        }

        public ResponseDto UpdateStock(Guid productId,int count)
        {
            ResponseDto response = new();
            var product = _productDal.Get(p => p.Id == productId);
            if (product == null)
                return Error.ProductNotFound.JsonSerialize().JsonDeserialize<ResponseDto>();

            product.Stock -= count;

            if (!_productDal.SaveChanges())
                response.IsSuccess = false;

            return response;
        }
    }
}
