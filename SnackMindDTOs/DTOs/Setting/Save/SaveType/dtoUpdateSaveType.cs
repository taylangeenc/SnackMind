﻿using System;

namespace SnackMindDTOs.DTOs.Setting.Save.SaveType
{
    public class dtoUpdateSaveType
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}