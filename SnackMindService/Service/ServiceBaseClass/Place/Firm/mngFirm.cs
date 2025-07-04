using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Place.Firm;

using SnackMindService.Service.ServiceBase.Place.Firm;

namespace SnackMindService.Service.ServiceBaseClass.Place.Firm
{
    public class mngFirm : SmService<mdlFirm>, IFirmService
    {
        public mngFirm(IUnitOfWork unitOfWork, ISmRepository<mdlFirm> repository) : base(unitOfWork, repository)
        {
        }
    }
}