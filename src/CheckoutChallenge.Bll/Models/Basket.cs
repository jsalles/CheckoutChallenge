using System.Collections.Generic;

namespace CheckoutChallenge.Bll.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public List<Product> ProductList { get; set; }
    }
}