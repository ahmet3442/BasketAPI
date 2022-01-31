using Core.Common.Service;
using Entity.DTOs;


namespace Business.Abstract
{
    public interface IOrderService
    {
        ResponseDto CreateOrder(BasketDto dto);
    }
}
