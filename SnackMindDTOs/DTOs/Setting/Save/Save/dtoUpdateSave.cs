using System;

namespace SnackMindDTOs.DTOs.Setting.Save.Save
{
    public class dtoUpdateSave
    {
        public Guid Ref { get; set; }
        public string Action { get; set; }
        public string Detail { get; set; }
        public DateTime LoggedDate { get; set; }

        public Guid FirmRef { get; set; }
        public Guid BranchRef { get; set; }
        public Guid UserRef { get; set; }
        public Guid SaveTypeRef { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}