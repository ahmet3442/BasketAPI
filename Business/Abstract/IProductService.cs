using Core.Common.Service;
using System;


namespace Business.Abstract
{
    public interface IProductService
    {
        ResponseDto GetProductPrice(Guid productId);
        ResponseDto GetProductPriceWithCampaign(Guid productId);
        ResponseDto ProductStockControl(Guid productId, int count);
        ResponseDto GetProduct(Guid productId);
        ResponseDto UpdateStock(Guid productId, int count);
    }
}
