using SnackMindCore.BaseClass;

using SnackMindModel.Model.Place.Branch;
using SnackMindModel.Model.Setting.Save;

using System.Collections.Generic;

namespace SnackMindModel.Model.Place.Firm
{
    public class mdlFirm : Entity
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Address { get; set; }

        public virtual ICollection<mdlBranch> Branches { get; set; }
        public virtual ICollection<mdlSave> Saves { get; set; }
    }
}