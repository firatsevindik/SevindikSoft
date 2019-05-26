using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sevindik.Northwind.MvcWebUI.Models;
using Sevindik.Northwind.MvcWebUI.Services;

namespace Sevindik.Northwind.MvcWebUI.ViewComponents
{
    public class CartSummaryViewComponent:ViewComponent
    {
        private ICartSessionService _cartSessionService;

        public CartSummaryViewComponent(ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }

        public IViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel
            {
                Cart = _cartSessionService.GetCart()
            };

            return View(model);
        }
    }
}
