using SnackMindData.Repository.IRepository.Place.Branch;
using SnackMindData.Repository.IRepository.Table.Table;
using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Place.Zone;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Place.Zone;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SnackMindService.Service.Service.Place.Zone
{
    public class ZoneService : SmService<mdlZone>, IZoneService
    {
        public ZoneService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.Zone)
        {

        }
    }
}