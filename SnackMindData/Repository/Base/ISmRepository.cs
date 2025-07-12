using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SnackMindData.Repository.Base
{
    public interface ISmRepository<T> where T : class
    {
        Task<T> GetByRefAsync(Guid reference);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);

        Task Add(T entity);
        Task AddRange(IEnumerable<T> entities);

        Task Update(T entity);
        Task UpdateRange(IEnumerable<T> entities);

        Task Delete(Guid reference);
        Task DeleteRange(IEnumerable<Guid> references);
    }
}