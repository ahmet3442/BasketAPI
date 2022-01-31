using Core.Common.Service;
using Entity.DTOs;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBasketService
    {
        Task<ResponseDto> UpdateBasket(UpdateBasketDto dto, CancellationToken cancellationToken);
        Task<ResponseDto> ConfirmBasket(CancellationToken cancellationToken);
        Task<ResponseDto> CreateBasket(CancellationToken cancellationToken);
        Task<ResponseDto> GetBasket(CancellationToken cancellationToken);
        Task<ResponseDto> DeleteBasket(CancellationToken cancellationToken);

    }
}

