namespace CheckoutChallenge.Api.Models
{
    public class BasketResponse
    {
        public bool Error {get;set;}
        public string Message {get;set;}
        public Bll.Models.Basket Data {get;set;}
    }
}