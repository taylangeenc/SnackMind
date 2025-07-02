using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindService.Service.ServiceBase;

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SnackMindService.Service.ServiceBaseClass
{
    public class SmService<T> : ISmService<T> where T : class
    {
        protected readonly IUnitOfWork _unitOfWork;
        private readonly ISmRepository<T> _repository;
        protected SmService(IUnitOfWork unitOfWork, ISmRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<bool> AddAsync(T entity)
        {
            try
            {
                await _repository.AddAsync(entity);
                return await _unitOfWork.CommitAsync() > 0;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(Guid Ref)
        {
            try
            {
                await _repository.DeleteAsync(Ref);
                return await _unitOfWork.CommitAsync() > 0;
            }
            catch
            {
                return false;
            }
        }

        public Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? _repository.GetAllAsync() : _repository.GetAllAsync(filter);
        }

        public Task<T> GetByRefAsync(Guid Ref)
        {
            return _repository.GetByRefAsync(Ref);
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            try
            {
                await _repository.UpdateAsync(entity);
                return await _unitOfWork.CommitAsync() > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}