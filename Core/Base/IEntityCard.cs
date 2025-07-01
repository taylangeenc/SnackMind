using System;

namespace SnackMindCore.Base
{
    public interface IEntityCard : IEntity
    {
        string Name { get; set; }
        string Description { get; set; }
        bool IsActive { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }
    }
}