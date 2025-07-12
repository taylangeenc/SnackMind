using SnackMindDTOs.DTOs.Setting.Save.Save;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Setting.Save.SaveType
{
    public class dtoDetailSaveType : dtoSaveType
    {
        public List<dtoSave> Saves { get; set; }
    }
}