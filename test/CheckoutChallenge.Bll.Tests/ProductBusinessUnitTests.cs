using NUnit.Framework;
using CheckoutChallenge.Bll.Interfaces;
using CheckoutChallenge.Bll.Implementation;

namespace CheckoutChallenge.Bll.Tests
{
    [TestFixture]
    public class ProductBusinessUnitTests
    {
        [Test]
        public void GetById_DummyTest()
        {
            var productBusiness = new ProductBusiness();
            Assert.IsNotNull(productBusiness.GetByCode("some product code"));
        }
    }
}
