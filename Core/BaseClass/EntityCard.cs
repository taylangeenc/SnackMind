using SnackMindCore.Base;

using System;

namespace SnackMindCore.BaseClass
{
    public class EntityCard : Entity, IEntityCard
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}