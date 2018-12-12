using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(int id, string name, double cost, double price)
        {
            Id = id;
            Name = name;
            Cost = cost;
            Price = price;
            Quantity = 0;
        }
    }
}
