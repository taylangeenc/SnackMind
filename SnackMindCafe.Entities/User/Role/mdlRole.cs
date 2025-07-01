using SnackMindCore.BaseClass;

using SnackMindModel.User.User;

using System;
using System.Collections.Generic;

namespace SnackMindModel.User.Role
{
    public class mdlRole : EntityCard
    {
        public string Permission { get; set; } //Json

        public virtual ICollection<mdlUser> Users { get; set; }
    }
}