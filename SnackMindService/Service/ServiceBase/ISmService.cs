using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SnackMindService.Service.ServiceBase
{
    public interface ISmService<T> where T : class
    {
        Task<T> GetByRefAsync(Guid Ref);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
        Task<bool> AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(Guid Ref);
    }
}