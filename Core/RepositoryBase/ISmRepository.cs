using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SnackMindCore.RepositoryBase
{
    public interface ISmRepository<T> where T : class
    {
        Task<T> GetByRefAsync(Guid Ref);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> Filter = null);
        Task AddAsync(T Entity);
        Task UpdateAsync(T Entity);
        Task DeleteAsync(Guid Ref);
        //Task SaveAsync();
    }
}