using SnackMindData.Repository.Base;
using SnackMindData.Repository.IRepository.Product.Category;
using SnackMindData.Repository.IRepository.Product.Unit;
using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Product.Product;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Product.Product;

namespace SnackMindService.Service.Service.Product.Product
{
    public class ProductService : SmService<mdlProduct>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.Product)
        {

        }
    }
}