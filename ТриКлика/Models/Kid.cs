using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ТриКлика.Models
{
    public class Kid
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string productName { get; set; }
        [Required]
        public string productPrice { get; set; }
        public string discountPrice { get; set; }
        public string productCategory { get; set; }
        public string productDescription { get; set; }
        [Required]
        public string productImageOne { get; set; }
        public string productImageTwo { get; set; }
        public string productImageThree { get; set; }
    }
}