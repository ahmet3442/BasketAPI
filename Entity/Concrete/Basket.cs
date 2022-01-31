
using Core.Common.Enums;
using Entity.Definitions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Basket : IEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid OrderId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid BasketProductId { get; set; }

    }
}
