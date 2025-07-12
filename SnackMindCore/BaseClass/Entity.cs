using SnackMindCore.Base;

using System;
using System.ComponentModel.DataAnnotations;

namespace SnackMindCore.BaseClass
{
    public class Entity : IEntity
    {
        public Guid Ref { get; set; } = Guid.Empty;
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
    }
}