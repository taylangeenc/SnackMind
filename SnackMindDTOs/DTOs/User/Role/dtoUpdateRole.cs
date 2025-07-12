using System;

namespace SnackMindDTOs.DTOs.User.Role
{
    public class dtoUpdateRole
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }
        public string Permission { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}