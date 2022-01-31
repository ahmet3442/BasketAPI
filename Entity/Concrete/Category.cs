using Entity.Definitions;
using System;

namespace Entity.Concrete
{
    public class Category : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
