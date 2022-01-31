using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DataAccess.Definitions;
using DataAccess.Definitions.EntityFramework;
using DataAccess.Definitions.UnitOfWork;
using DataAccess.Concrete;

namespace Dal.Extensions
{
    public static class DalExtensions
    {
        public static void AddDataModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<DbContext, BasketDbContext>();
            services.AddScoped(typeof(IEntityRepository<>), typeof(EfRepositoryBase<>));
            services.AddTransient<IUnitOfWork, efUnitOfWork>();


            services.Scan(x => x.FromCallingAssembly()
              .AddClasses(s => s.Where(t => t.Name.EndsWith("Dal")))
              .AsImplementedInterfaces());





        }
    }
}
