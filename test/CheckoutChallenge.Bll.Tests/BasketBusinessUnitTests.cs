using NUnit.Framework;
using CheckoutChallenge.Bll.Interfaces;
using CheckoutChallenge.Bll.Implementation;

namespace CheckoutChallenge.Bll.Tests
{
    [TestFixture]
    public class BasketBusinessUnitTests
    {
        [Test]
        public void GetByCode_DummyTest()
        {
            var basketBusiness = new BasketBusiness();
            Assert.IsNotNull(basketBusiness.GetById(1));
        }
    }
}
