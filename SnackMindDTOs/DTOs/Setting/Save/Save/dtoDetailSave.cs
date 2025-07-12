using SnackMindDTOs.DTOs.Place.Branch;
using SnackMindDTOs.DTOs.Place.Firm;
using SnackMindDTOs.DTOs.Setting.Save.SaveType;
using SnackMindDTOs.DTOs.User.User;

namespace SnackMindDTOs.DTOs.Setting.Save.Save
{
    public class dtoDetailSave : dtoSave
    {
        public string FirmName { get; set; }
        public string BranchName { get; set; }
        public string UserFullName { get; set; }
        public string SaveTypeName { get; set; }

        public dtoFirm Firm { get; set; }
        public dtoBranch Branch { get; set; }
        public dtoUser User { get; set; }
        public dtoSaveType SaveType { get; set; }
    }
}