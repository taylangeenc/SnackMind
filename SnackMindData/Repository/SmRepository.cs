using SnackMindCore.BaseClass;
using SnackMindCore.RepositoryBase;

using SnackMindData.Context;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SnackMindData.Repository
{
    public class SmRepository<T> : ISmRepository<T> where T : Entity
    {
        protected readonly SmContext _context;
        protected readonly DbSet<T> _dbSet;
        public SmRepository(SmContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public virtual async Task<T> GetByRefAsync(Guid Ref)
        {
            return await _dbSet.FindAsync(Ref);
        }
        public virtual async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> Filter = null)
        {
            return Filter == null ? await _dbSet.ToListAsync() : await _dbSet.Where(Filter).ToListAsync();
        }
        public virtual Task AddAsync(T Entity)
        {
            _dbSet.Add(Entity);
            return Task.CompletedTask;
        }
        public virtual Task UpdateAsync(T Entity)
        {
            _context.Entry(Entity).State = EntityState.Modified;
            return Task.CompletedTask;
        }
        public virtual async Task DeleteAsync(Guid Ref)
        {
            var entity = await _dbSet.FindAsync(Ref);
            if (entity != null)
                _dbSet.Remove(entity);
        }
        //public async Task SaveAsync()
        //{
        //    await _context.SaveChangesAsync();
        //}
    }
}