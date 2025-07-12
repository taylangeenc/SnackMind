using System;

namespace SnackMindDTOs.DTOs.Place.Firm
{
    public class dtoUpdateFirm
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}