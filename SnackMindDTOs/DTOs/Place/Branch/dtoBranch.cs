using System;

namespace SnackMindDTOs.DTOs.Place.Branch
{
    public class dtoBranch
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}