using System;
using System.Collections.Generic;
using AutoParts.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoParts.Test
{
    [TestClass]
    public class InvoiceTest
    {
        [TestMethod]
        public void ShouldCreateNewInvoice()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product(1,"Martillo",20,25));

            Invoice invoice = new Invoice(1,products,new List<int>() { 1},new Customer (1,"Carlos","Colonia Valle",2556698) );
            Assert.IsNotNull(invoice);
        }

    }
}
