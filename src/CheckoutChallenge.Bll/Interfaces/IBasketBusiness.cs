
using System.Collections.Generic;
using CheckoutChallenge.Bll.Models;

namespace CheckoutChallenge.Bll.Interfaces
{
    public interface IBasketBusiness
    {
        Basket GetById(int basketId);
    }
}