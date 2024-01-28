using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ТриКлика.Models
{
    public class ProductToCart
    {

        public int productID { get; set; }
        public int shoppingCartID { get; set; }
        public Product product { get; set; }
        public ShoppingCart shoppingCart { get; set; }
    }
}