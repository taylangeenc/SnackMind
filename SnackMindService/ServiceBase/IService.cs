using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SnackMindService.ServiceBase
{
    public interface IService<T> where T : class
    {
        T GetByRef(Guid Ref);
        List<T> GetAll(Expression<Func<T, bool>> Filter = null);
        bool Add(T Entity);
        bool Update(T Entity);
        bool Delete(T Entity);
    }
}