
using System.Collections.Generic;
using System.Threading.Tasks;
using CheckoutChallenge.Bll.Models;
using CheckoutChallenge.Bll.Interfaces;

namespace CheckoutChallenge.Bll.Implementation
{
    public class ProductBusiness : IProductBusiness
    {
        public Product GetByCode(string productCode)
        {
            return new Product
            {
                Id = 1,
                Code = productCode
            };
        }
    }
}