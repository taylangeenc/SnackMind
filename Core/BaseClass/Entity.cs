using SnackMindCore.Base;

using System;

namespace SnackMindCore.BaseClass
{
    public class Entity : IEntity
    {
        public Guid Ref { get; set; } = Guid.Empty;
    }
}