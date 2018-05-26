
using System.Collections.Generic;
using System.Threading.Tasks;
using CheckoutChallenge.Bll.Models;
using CheckoutChallenge.Bll.Interfaces;

namespace CheckoutChallenge.Bll.Implementation
{
    public class BasketBusiness : IBasketBusiness
    {
        public Basket GetById(int basketId)
        {
            return new Bll.Models.Basket
            {
                Id = basketId,
                ProductList = new List<Bll.Models.Product>
                {
                    new Bll.Models.Product{ Id = 1, Code = "A001" },
                    new Bll.Models.Product{ Id = 2, Code = "A002" }
                }
            };
        }
    }
}