using DataAccess.Abstract;
using DataAccess.Definitions.EntityFramework;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfOrderDal : EfRepositoryBase<Order>, IOrderDal
    {
        public EfOrderDal(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
