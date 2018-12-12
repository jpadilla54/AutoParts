using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.Domain.Entities
{


    public class Invoice
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public List<int> ProductsAmount { get; set; }
        public Customer Customer { get; set; }

        public Invoice(int id, List<Product> products, List<int> productsamount, Customer customer)
        {
            Id = id;
            Products = products;
            ProductsAmount = productsamount;
            Customer = customer;
        }
    }
}
