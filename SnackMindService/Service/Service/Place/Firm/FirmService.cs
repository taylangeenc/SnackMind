using SnackMindData.Repository.IRepository.Place.Branch;
using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Place.Firm;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Place.Firm;

using System;
using System.Threading.Tasks;

namespace SnackMindService.Service.Service.Place.Firm
{
    public class FirmService : SmService<mdlFirm>, IFirmService
    {
        private readonly IBranchRepository _branchRepository;
        public FirmService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.Firm)
        {
            _branchRepository = unitOfWork.Branch;
        }
    }
}