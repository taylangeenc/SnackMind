using SnackMindData.Repository.IRepository.Place.Branch;
using SnackMindData.Repository.IRepository.Product.Ingredient;
using SnackMindData.Repository.IRepository.Product.Stock.Ingredient;
using SnackMindData.Repository.IRepository.Product.Stock.Product;
using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Place.Warehouse;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Place.Warehouse;

using System;
using System.Linq;
using System.Threading.Tasks;

namespace SnackMindService.Service.Service.Place.Warehouse
{
    public class WarehouseService : SmService<mdlWarehouse>, IWarehouseService
    {
        public WarehouseService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.Warehouse)
        {

        }
    }
}