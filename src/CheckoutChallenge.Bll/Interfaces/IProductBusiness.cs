
using System.Collections.Generic;
using CheckoutChallenge.Bll.Models;

namespace CheckoutChallenge.Bll.Interfaces
{
    public interface IProductBusiness
    {
        Product GetByCode(string productCode);
    }
}