using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SnackMindApp.AppService.Base
{
    public interface ISmAppService<TCreateDto, TUpdateDto, TDetailDto, TListDto>
    {
        Task<TDetailDto> AddAsync(TCreateDto createDto);
        Task<TDetailDto> UpdateAsync(TUpdateDto updateDto, Guid reference);
        Task<TDetailDto> DeleteAsync(Guid reference);
        Task<List<TListDto>> GetAllAsync();
        Task<TDetailDto> GetByRefAsync(Guid reference);
    }
}