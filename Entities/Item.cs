using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Domain;

namespace Entities
{
    [Table("ItemInCart")]
    public class Item : DbEntity
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}