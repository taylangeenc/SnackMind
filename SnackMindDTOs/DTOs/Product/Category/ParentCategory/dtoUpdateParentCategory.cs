﻿using System;

namespace SnackMindDTOs.DTOs.Product.Category.ParentCategory
{
    public class dtoUpdateParentCategory
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}