using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Product.Category.ParentCategory;

namespace SnackMindApp.AppService.IAppService.Product.Category
{
    public interface IParentCategoryAppService : ISmAppService<dtoCreateParentCategory, dtoUpdateParentCategory, dtoDetailParentCategory, dtoListParentCategory>
    {
    }
}