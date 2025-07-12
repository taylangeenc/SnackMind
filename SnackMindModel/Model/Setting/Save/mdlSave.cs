using SnackMindCore.BaseClass;

using SnackMindModel.Model.Place.Branch;
using SnackMindModel.Model.Place.Firm;
using SnackMindModel.Model.User.User;

using System;

namespace SnackMindModel.Model.Setting.Save
{
    public class mdlSave : Entity
    {
        public string Action { get; set; }
        public string Detail { get; set; }
        public DateTime LoggedDate { get; set; }

        public Guid FirmRef { get; set; }
        public virtual mdlFirm Firm { get; set; }

        public Guid BranchRef { get; set; }
        public virtual mdlBranch Branch { get; set; }

        public Guid UserRef { get; set; }
        public virtual mdlUser User { get; set; }

        public Guid SaveTypeRef { get; set; }
        public virtual mdlSaveType SaveType { get; set; }
    }
}