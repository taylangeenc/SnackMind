using SnackMindDTOs.DTOs.Table.Table.Table;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Table.Table.TableState
{
    public class dtoDetailTableState : dtoTableState
    {
        public List<dtoTable> Tables { get; set; }
    }
}