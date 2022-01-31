using DataAccess.Abstract;
using DataAccess.Definitions.EntityFramework;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concrete
{
    public class EfProductPriceDal : EfRepositoryBase<ProductPrice>, IProductPriceDal
    {
        public EfProductPriceDal(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
