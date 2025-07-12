using System;

namespace SnackMindDTOs.DTOs.User.Role
{
    public class dtoRole
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }
        public string Permission { get; set; } // JSON

        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}