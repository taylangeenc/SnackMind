using System;

namespace SnackMindDTOs.DTOs.Reservation.Customer
{
    public class dtoUpdateCustomer
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}