using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Sevindik.Northwind.Entities.Concrete;
using Sevindik.Northwind.MvcWebUI.ExtensionMethods;

namespace Sevindik.Northwind.MvcWebUI.Services
{
    public class CartSessionService:ICartSessionService
    {
        private IHttpContextAccessor _httpContextAccessor;

        public CartSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Cart GetCart()
        {
            Cart cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            if (cartToCheck == null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("cart",new Cart());
                cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            }

            return cartToCheck;
        }

        public void SetCart(Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("cart",cart);
        }
    }
}
