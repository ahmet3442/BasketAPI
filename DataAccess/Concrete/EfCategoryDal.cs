using DataAccess.Abstract;
using DataAccess.Definitions.EntityFramework;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concrete
{
    public class EfCategoryDal : EfRepositoryBase<Category>, ICategoryDal
    {
        public EfCategoryDal(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
