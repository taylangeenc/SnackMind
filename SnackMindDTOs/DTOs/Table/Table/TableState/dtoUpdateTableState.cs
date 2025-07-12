using System;

namespace SnackMindDTOs.DTOs.Table.Table.TableState
{
    public class dtoUpdateTableState
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}