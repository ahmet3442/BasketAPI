using DataAccess.Abstract;
using DataAccess.Definitions.EntityFramework;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concrete
{
    public class EfProductDal : EfRepositoryBase<Product>, IProductDal
    {
        public EfProductDal(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
