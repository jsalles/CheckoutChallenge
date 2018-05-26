namespace CheckoutChallenge.Api.Models
{
    public class ProductResponse
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public Bll.Models.Product Data { get; set; }
    }
}