using AutoParts.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoParts.Test
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void ShouldCreateProduct()
        {
            Product product = new Product(1, "Tornillo", 0.5, 1.5);
            Assert.IsNotNull(product);
            Assert.AreEqual(1, product.Id);
            Assert.AreEqual("Tornillo", product.Name);
        }


        [TestMethod]
        public void ShouldAddProductAndQuantityShouldBe0()
        {
            Product product = new Product(1, "Tornillo", 0.5, 1.5);
            Assert.AreEqual(0, product.Quantity);
        }

        [TestMethod]
        public void ShouldAddProductToInventary()
        {
            Product product = new Product(1, "Tornillo", 0.5, 1.5);
            product.AddToInventory(1);
            Assert.AreEqual(1, product.Quantity);
        }

    }
}
