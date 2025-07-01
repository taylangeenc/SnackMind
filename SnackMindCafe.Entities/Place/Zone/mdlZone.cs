using SnackMindCore.BaseClass;

using SnackMindModel.Place.Branch;
using SnackMindModel.Table.Table;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Place.Zone
{
    public class mdlZone : EntityCard
    {
        public bool IsOutdoor { get; set; }

        public Guid BranchRef { get; set; }
        public virtual mdlBranch Branch { get; set; }

        public virtual ICollection<mdlTable> Tables { get; set; }
    }
}