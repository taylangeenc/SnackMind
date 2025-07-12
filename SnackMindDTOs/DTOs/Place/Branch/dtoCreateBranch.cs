using System;

namespace SnackMindDTOs.DTOs.Place.Branch
{
    public class dtoCreateBranch
    {
        public string Name { get; set; }
        public string DatabaseName { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Guid FirmRef { get; set; }

        public string Description { get; set; }
    }
}