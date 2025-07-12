using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Place.Firm;

using SnackMindModel.Model.Place.Firm;

namespace SnackMindData.Repository.Repository.Place.Firm
{
    public class FirmRepository : SmRepository<mdlFirm>, IFirmRepository
    {
        public FirmRepository(SmContext context) : base(context)
        {
            
        }
    }
}