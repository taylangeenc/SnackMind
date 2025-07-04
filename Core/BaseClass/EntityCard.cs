using SnackMindCore.Base;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SnackMindCore.BaseClass
{
    public class EntityCard : Entity, IEntityCard
    {
        [Column(TypeName = "nvarchar")]
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(500)]
        [Required]
        public string Description { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime UpdatedDate { get; set; }
    }
}