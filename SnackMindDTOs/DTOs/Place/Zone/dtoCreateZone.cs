using System;

namespace SnackMindDTOs.DTOs.Place.Zone
{
    public class dtoCreateZone
    {
        public string Name { get; set; }
        public bool IsOutdoor { get; set; }
        public Guid BranchRef { get; set; }
        public string Description { get; set; }
    }
}