using System;

namespace SnackMindDTOs.DTOs.Place.Warehouse
{
    public class dtoUpdateWarehouse
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }

        public Guid BranchRef { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}