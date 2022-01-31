using DataAccess.Abstract;
using DataAccess.Definitions.EntityFramework;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concrete
{
    public class EfCampaignDal : EfRepositoryBase<Campaign>, ICampaignDal
    {
        public EfCampaignDal(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
