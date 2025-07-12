using SnackMindCore.BaseClass;

using System.Collections.Generic;

namespace SnackMindModel.Model.Setting.Save
{
    public class mdlSaveType : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<mdlSave> Saves { get; set; }
    }
}