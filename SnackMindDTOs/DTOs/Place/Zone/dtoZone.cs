using System;

namespace SnackMindDTOs.DTOs.Place.Zone
{
    public class dtoZone
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }
        public bool IsOutDoor { get; set; }

        public Guid BranchRef { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}