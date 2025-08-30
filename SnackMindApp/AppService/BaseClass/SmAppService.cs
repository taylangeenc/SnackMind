using AutoMapper;

using FluentValidation;

using SnackMindApp.AppService.Base;

using SnackMindService.Service.Base;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SnackMindApp.AppService.BaseClass
{
    public class SmAppService<TCreateDto, TUpdateDto, TDetailDto, TListDto, TEntity> : ISmAppService<TCreateDto, TUpdateDto, TDetailDto, TListDto>
        where TEntity : class
    {
        protected readonly ISmService<TEntity> _service;
        protected readonly IMapper _mapper;
        public SmAppService(
            ISmService<TEntity> service,
            IMapper mapper,
            IValidator<TCreateDto> createValidator,
            IValidator<TUpdateDto> updateValidator)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<TDetailDto> AddAsync(TCreateDto createDto)
        {
            var entity = _mapper.Map<TEntity>(createDto);
            await _service.Add(entity);
            await _service.SaveChangesAsync();
            return _mapper.Map<TDetailDto>(entity);
        }

        public async Task<TDetailDto> DeleteAsync(Guid reference)
        {
            var entity = await _service.GetByRefAsync(reference);
            await _service.Delete(reference);
            await _service.SaveChangesAsync();
            return _mapper.Map<TDetailDto>(entity);
        }

        public async Task<List<TListDto>> GetAllAsync()
        {
            var list = await _service.GetAllAsync();
            return _mapper.Map<List<TListDto>>(list);
        }

        public async Task<TDetailDto> GetByRefAsync(Guid reference)
        {
            var entity = await _service.GetByRefAsync(reference);
            return _mapper.Map<TDetailDto>(entity);
        }

        public async Task<TDetailDto> UpdateAsync(TUpdateDto updateDto, Guid reference)
        {
            var entity = await _service.GetByRefAsync(reference);
            _mapper.Map(updateDto, entity);
            await _service.Update(entity);
            await _service.SaveChangesAsync();
            return _mapper.Map<TDetailDto>(entity);
        }
    }
}