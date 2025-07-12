using SnackMindDTOs.DTOs.Table.Table.Table;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Place.Zone
{
    public class dtoDetailZone : dtoZone
    {
        public string BranchName { get; set; }

        public List<dtoTable> Tables { get; set; }
    }
}