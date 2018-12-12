using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.Domain.Entities
{
    public class Inventary
    {
        public int IdInv { get; set; }
        public int IdPro { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Inventary(int idinv, int idpro, string name, double cost, double price, int cant)
        {
            IdInv = idinv;
            IdPro = idpro;
            Name = name;
            Cost = cost;
            Price = price;
            Quantity = 0;
        }
    }
}
