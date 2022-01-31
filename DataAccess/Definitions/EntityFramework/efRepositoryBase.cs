using Microsoft.EntityFrameworkCore;
using Entity.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using System.Threading;

namespace DataAccess.Definitions.EntityFramework
{
    public class EfRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        private readonly DbContext _context;
        public DbSet<TEntity> dbSet { get; }

        public EfRepositoryBase(DbContext context)
        {
            _context = context;
            _context.DetectChangesLazyLoading(false);
            dbSet = context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            var activeEntity = dbSet.Add(entity);
            activeEntity.State = EntityState.Added;
        }

        public void Delete(TEntity entity)
        {
            _context.DetectChangesLazyLoading(true);

            var activeEntity = _context.Entry(entity);
            activeEntity.State = EntityState.Deleted;

            _context.DetectChangesLazyLoading(false);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> condition)
        {
            return _context.Set<TEntity>().SingleOrDefault(condition);
        }

        public TEntity GetDetached(Expression<Func<TEntity, bool>> condition)
        {
            var result = _context.Set<TEntity>().SingleOrDefault(condition);
            var activeEntity = _context.Entry(result);
            activeEntity.State = EntityState.Detached;
            return result;
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> condition = null)
        {
            var list = condition == null ?
                _context.Set<TEntity>()
                .ToList() :
                _context.Set<TEntity>().Where(condition)
                .ToList();

            return list;
        }

        public void Update(TEntity entity)
        {
            _context.DetectChangesLazyLoading(true);

            dbSet.Attach(entity);
            var activeEntity = _context.Entry(entity);
            activeEntity.State = EntityState.Modified;

            _context.DetectChangesLazyLoading(false);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool SaveChanges()
        {
            try
            {
                Save();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }


        public async Task AddAsync(TEntity entity, CancellationToken cancellationToken)
        {
            var activeEntity = await dbSet.AddAsync(entity, cancellationToken);
            activeEntity.State = EntityState.Added;
        }

        public async Task DeleteAsync(TEntity entity, CancellationToken cancellationToken)
        {
            _context.DetectChangesLazyLoading(true);

            var activeEntity = _context.Entry(entity);
            activeEntity.State = EntityState.Deleted;

            _context.DetectChangesLazyLoading(false);
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> condition, CancellationToken cancellationToken, bool getFirst = false)
        {
            return getFirst ? await _context.Set<TEntity>().FirstOrDefaultAsync(condition, cancellationToken) :
                              await _context.Set<TEntity>().SingleOrDefaultAsync(condition, cancellationToken);
        }
        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> condition = null)
        {
            var list = condition == null ?
                _context.Set<TEntity>().ToList() : _context.Set<TEntity>().Where(condition).ToList();

            return list;
        }
        public async Task<TEntity> GetDetachedAsync(Expression<Func<TEntity, bool>> condition, CancellationToken cancellationToken, bool getFirst = false)
        {
            var result = getFirst ? await _context.Set<TEntity>().FirstOrDefaultAsync(condition, cancellationToken) :
                                    await _context.Set<TEntity>().SingleOrDefaultAsync(condition, cancellationToken);
            var activeEntity = _context.Entry(result);
            activeEntity.State = EntityState.Detached;
            return result;
        }

        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> condition, CancellationToken cancellationToken)
        {
            var list = condition == null ?
                await _context.Set<TEntity>()
                .ToListAsync(cancellationToken) :
                await _context.Set<TEntity>().Where(condition)
                .ToListAsync(cancellationToken);

            return list;
        }

        public async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken)
        {
            _context.DetectChangesLazyLoading(true);

            dbSet.Attach(entity);
            var activeEntity = _context.Entry(entity);
            activeEntity.State = EntityState.Modified;

            _context.DetectChangesLazyLoading(false);
        }

        public async Task SaveAsync(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<bool> SaveChangesAsync(CancellationToken cancellationToken)
        {
            try
            {
                await SaveAsync(cancellationToken);
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }
    }

}
