using System.Collections.Generic;
using CheckoutChallenge.Api.Models;
using CheckoutChallenge.Bll.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CheckoutChallenge.Api.Controllers
{
    [Route("api/product")]
    public class ProductController : Controller
    {
        private IProductBusiness _productBusiness;

        public ProductController(IProductBusiness productBusiness)
        {
            _productBusiness = productBusiness;
        }

        [Route("{productCode}")]
        public ActionResult Get(string productCode)
        {
            var response = new ProductResponse
            {
                Error = false,
                Message = "",
                Data = _productBusiness.GetByCode(productCode)
            };

            return Ok(response);
        }
    }
}