
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.Domain.Entities
{
    public class Customer
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Telephone { get; set; }


        public Customer(int id, string name, string address, int telephone)
        {

            Id = id;
            Name = name;
            Address = address;
            Telephone = telephone;


        }



    }
}