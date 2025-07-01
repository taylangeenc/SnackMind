using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Place.Firm;

using SnackMindModel.Place.Firm;

namespace SnackMindData.Repository.RepositoryBaseClass.Place.Firm
{
    public class FirmRepository : SmRepository<mdlFirm>, IFirmRepository
    {
        public FirmRepository(SmContext context) : base(context) { }
    }
}