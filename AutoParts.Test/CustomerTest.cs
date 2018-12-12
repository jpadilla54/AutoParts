using System;
using AutoParts.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoParts.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void shouldCreateCustomer()
        {
            Customer customer = new Customer(1, "Daniel", "Rivera Hernandez", 99716584);
            Assert.IsNotNull(customer);
            Assert.AreEqual(1, customer.Id);
        }


    }
}