using DataAccess.Abstract;
using DataAccess.Definitions.EntityFramework;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concrete
{
    public class EfBasketDal : EfRepositoryBase<Basket>, IBasketDal
    {
        public EfBasketDal(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
