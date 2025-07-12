using System;

namespace SnackMindDTOs.DTOs.User.User
{
    public class dtoCreateUser
    {
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }

        public Guid BranchRef { get; set; }
        public Guid RoleRef { get; set; }

        public string Description { get; set; }
    }
}