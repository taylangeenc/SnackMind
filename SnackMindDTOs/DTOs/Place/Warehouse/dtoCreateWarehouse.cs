using System;

namespace SnackMindDTOs.DTOs.Place.Warehouse
{
    public class dtoCreateWarehouse
    {
        public string Name { get; set; }
        public Guid BranchRef { get; set; }
        public string Description { get; set; }
    }
}