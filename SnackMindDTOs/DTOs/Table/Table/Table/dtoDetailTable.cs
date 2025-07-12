using SnackMindDTOs.DTOs.Order.Order;
using SnackMindDTOs.DTOs.Place.Zone;
using SnackMindDTOs.DTOs.Reservation.Reservation.Reservation;
using SnackMindDTOs.DTOs.Table.Table.TableState;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Table.Table.Table
{
    public class dtoDetailTable : dtoTable
    {
        public string ZoneName { get; set; }
        public string TableStateName { get; set; }

        public dtoZone Zone { get; set; }
        public dtoTableState TableState { get; set; }

        public List<dtoOrder> Orders { get; set; }
        public List<dtoReservation> Reservations { get; set; }
    }
}