using System.Collections.Generic;
using CheckoutChallenge.Api.Models;
using CheckoutChallenge.Bll.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CheckoutChallenge.Api.Controllers
{
    [Route("api/basket")]
    public class BasketController : Controller
    {
        private IBasketBusiness _basketBusiness;

        public BasketController(IBasketBusiness basketBusiness)
        {
            _basketBusiness = basketBusiness;
        }

        [Route("{basketId}")]
        public ActionResult Get(int basketId)
        {
            var response = new BasketResponse
            {
                Error = false,
                Message = "",
                Data = _basketBusiness.GetById(basketId)
            };

            return Ok(response);
        }
    }
}