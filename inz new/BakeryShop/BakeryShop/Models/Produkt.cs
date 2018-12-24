using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BakeryShop.Models
{
    public class Produkt
    {
        public int ProduktId { get; set; }
        public string Name { get; set; }
        public string Quanity { get; set; }
        public string Type { get; set; }
    }
}