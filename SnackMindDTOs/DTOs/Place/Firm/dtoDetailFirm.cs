using SnackMindDTOs.DTOs.Place.Branch;
using SnackMindDTOs.DTOs.Setting.Save.Save;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Place.Firm
{
    public class dtoDetailFirm : dtoFirm
    {
        public List<dtoBranch> Branches { get; set; }
        public List<dtoSave> Saves { get; set; }
    }
}