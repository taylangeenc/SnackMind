using SnackMindCore.BaseClass;

using System.Collections.Generic;

namespace SnackMindModel.Model.Table.Table
{
    public class mdlTableState : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<mdlTable> Tables { get; set; }
    }
}