using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class CartItem
    {
        [Key]
        public string ItemId { get; set; }
        public string CartId { get; set; }
        public int Quantity { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int ProductId { get; set; }
        public List<Product> Products { get; set; }

    }
}