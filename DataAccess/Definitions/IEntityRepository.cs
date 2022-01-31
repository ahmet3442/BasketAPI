using Microsoft.EntityFrameworkCore;
using Entity.Definitions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Threading;

namespace DataAccess.Definitions
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        DbSet<T> dbSet { get; }
        List<T> GetList(Expression<Func<T, bool>> condition = null);
        T Get(Expression<Func<T, bool>> condition);
        T GetDetached(Expression<Func<T, bool>> condition);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
        bool SaveChanges();

        Task<List<T>> GetListAsync(Expression<Func<T, bool>> condition, CancellationToken cancellationToken);
        Task<T> GetAsync(Expression<Func<T, bool>> condition, CancellationToken cancellationToken, bool getFirst = false);
        Task<T> GetDetachedAsync(Expression<Func<T, bool>> condition, CancellationToken cancellationToken, bool getFirst = false);
        Task  AddAsync(T entity, CancellationToken cancellationToken);
        Task UpdateAsync(T entity, CancellationToken cancellationToken);
        Task DeleteAsync(T entity, CancellationToken cancellationToken);
        Task SaveAsync(CancellationToken cancellationToken);
        Task<bool> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
