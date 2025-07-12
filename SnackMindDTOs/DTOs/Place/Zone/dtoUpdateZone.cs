using System;

namespace SnackMindDTOs.DTOs.Place.Zone
{
    public class dtoUpdateZone
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }
        public bool IsOutDoor { get; set; }
        public Guid BranchRef { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}