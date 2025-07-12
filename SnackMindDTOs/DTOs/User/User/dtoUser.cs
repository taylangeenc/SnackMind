using System;

namespace SnackMindDTOs.DTOs.User.User
{
    public class dtoUser
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }

        public Guid BranchRef { get; set; }
        public Guid RoleRef { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}