using SnackMindCore.BaseClass;

using SnackMindModel.Place.Branch;
using SnackMindModel.Setting.Log;

using System.Collections.Generic;

namespace SnackMindModel.Place.Firm
{
    public class mdlFirm : EntityCard
    {
        public string ImagePath { get; set; }
        public string Address { get; set; }

        public virtual ICollection<mdlBranch> Branches { get; set; }
        public virtual ICollection<mdlLog> Logs { get; set; }
    }
}