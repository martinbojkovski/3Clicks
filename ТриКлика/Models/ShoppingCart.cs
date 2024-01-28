using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ТриКлика.Models
{
    public class ShoppingCart
    {

        public ShoppingCart()
        {
            products = new List<Product>();
        }

        [Key]
        public int ID { get; set; }
        public string productQuantity { get; set; }
        public virtual List<Product> products { get; set; }
    }
}