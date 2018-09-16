using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inzynierka_Shop.Models
{
    public class Produkt
{
    public int ID { get; set; }
    public string Nazwa { get; set; }
    public string Kategoria  { get; set; }
    public string Ilosc { get; set; }
    public decimal Cena { get; set; }
}
}