using SnackMindCore.BaseClass;

using SnackMindModel.Model.User.User;

using System.Collections.Generic;

namespace SnackMindModel.Model.User.Role
{
    public class mdlRole : Entity
    {
        public string Name { get; set; }
        public string Permission { get; set; } //Json

        public virtual ICollection<mdlUser> Users { get; set; }
    }
}