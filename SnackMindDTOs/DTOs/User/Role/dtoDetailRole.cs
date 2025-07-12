using SnackMindDTOs.DTOs.User.User;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.User.Role
{
    public class dtoDetailRole : dtoRole
    {
        public List<dtoUser> Users { get; set; }
    }
}