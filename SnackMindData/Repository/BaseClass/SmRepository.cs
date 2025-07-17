using SnackMindCore.BaseClass;

using SnackMindData.Context;
using SnackMindData.Repository.Base;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SnackMindData.Repository.BaseClass
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

        public Task Add(T entity)
        {
            _dbSet.Add(entity);
            return Task.CompletedTask;
        }

        public Task AddRange(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
            return Task.CompletedTask;
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.AnyAsync(filter);
        }

        public async Task Delete(Guid reference)
        {
            //var entity = await _dbSet.FindAsync(reference);
            //if (entity != null)
            //    _dbSet.Remove(entity);
            var entity = await _dbSet.FindAsync(reference);
            if (entity != null)
            {
                entity.IsActive = false;
                await Update(entity);
            }
        }

        public async Task DeleteRange(IEnumerable<Guid> references)
        {
            var entities = await _dbSet.Where(x => references.Contains(x.Ref)).ToListAsync();
            if (entities != null)
                _dbSet.RemoveRange(entities);
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null)
        {
            return filter == null
                ? await _dbSet.ToListAsync()
                : await _dbSet.Where(filter).ToListAsync();
        }

        public async Task<T> GetByRefAsync(Guid reference)
        {
            return await _dbSet.FindAsync(reference);
        }

        public Task Update(T entity)
        {
            if(entity != null)
                _context.Entry(entity).State = EntityState.Modified;
            return Task.CompletedTask;
        }

        public Task UpdateRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
                _context.Entry(entity).State = EntityState.Modified;
            return Task.CompletedTask;
        }
    }
}