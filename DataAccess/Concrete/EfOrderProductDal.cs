using DataAccess.Abstract;
using DataAccess.Definitions.EntityFramework;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class EfOrderProductDal : EfRepositoryBase<OrderProduct>, IOrderProductDal
    {
        public EfOrderProductDal(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
