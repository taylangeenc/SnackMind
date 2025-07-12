using System;

namespace SnackMindDTOs.DTOs.Place.Warehouse
{
    public class dtoWarehouse
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }

        public Guid BranchRef { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}