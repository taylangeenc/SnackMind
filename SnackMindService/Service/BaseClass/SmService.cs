using SnackMindData.Repository.Base;
using SnackMindData.UnitOfWork;

using SnackMindService.Service.Base;

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SnackMindService.Service.BaseClass
{
    public class SmService<T> : ISmService<T> where T : class
    {
        protected readonly IUnitOfWork _unitOfWork;
        private readonly ISmRepository<T> _repository;
        public SmService(IUnitOfWork unitOfWork, ISmRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
        public async Task<T> GetByRefAsync(Guid reference)
        {
            return await _repository.GetByRefAsync(reference);
        }
        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null)
        {
            return await _repository.GetAllAsync(filter);
        }
        public async Task Add(T entity)
        {
            await _repository.Add(entity);
        }
        public async Task AddRange(IEnumerable<T> entities)
        {
            await _repository.AddRange(entities);
        }
        public async Task Update(T entity)
        {
            await _repository.Update(entity);
        }
        public async Task UpdateRange(IEnumerable<T> entities)
        {
            await _repository.UpdateRange(entities);
        }
        public async Task Delete(Guid reference)
        {
            await _repository.Delete(reference);
        }
        public async Task DeleteRange(IEnumerable<Guid> references)
        {
            await _repository.DeleteRange(references);
        }
        public void Save()
        {
            _unitOfWork.Commit();
        }
        public async Task SaveChangesAsync()
        {
            await _unitOfWork.CommitAsync();
        }
        public void BeginTransaction()
        {
            _unitOfWork.BeginTransaction();
        }
        public void CommitTransaction()
        {
            _unitOfWork.CommitTransaction();
        }
        public void RollbackTransaction()
        {
            _unitOfWork.RollbackTransaction();
        }
    }
}