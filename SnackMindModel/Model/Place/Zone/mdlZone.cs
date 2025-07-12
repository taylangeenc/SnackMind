using SnackMindCore.BaseClass;

using SnackMindModel.Model.Place.Branch;
using SnackMindModel.Model.Table.Table;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Model.Place.Zone
{
    public class mdlZone : Entity
    {
        public string Name { get; set; }
        public bool IsOutdoor { get; set; }

        public Guid BranchRef { get; set; }
        public virtual mdlBranch Branch { get; set; }

        public virtual ICollection<mdlTable> Tables { get; set; }
    }
}