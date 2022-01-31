using System;
using Entity.Definitions;

namespace DataAccess.Definitions
{
    public interface IUnitOfWork : IDisposable
    {
        IEntityRepository<T> GetRepository<T>() where T : class, IEntity, new();
        bool BeginNewTransaction();
        bool RollBackTransaction();
        bool SaveChanges();
        bool Commit();
    }
}