using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sevindik.Northwind.Business.Abstract;
using Sevindik.Northwind.Entities.Concrete;
using Sevindik.Northwind.MvcWebUI.Models;
using Sevindik.Northwind.MvcWebUI.Services;

namespace Sevindik.Northwind.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public IActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);

            var cart = _cartSessionService.GetCart();

            _cartService.AddToCart(cart,productToBeAdded);

            _cartSessionService.SetCart(cart);

            TempData.Add("message", String.Format("Your product {0} was successfully added to the cart!",productToBeAdded.ProductName));

            return RedirectToAction("Index", "Product");

        }

        public IActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartListViewModel cartListViewModel=new CartListViewModel()
            {
                Cart = cart
            };

            return View(cartListViewModel);
        }

        public IActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart,productId);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", String.Format("Your product was successfully removed from the cart!"));

            return RedirectToAction("List");
        }

        public IActionResult Complete()
        {
            var shippingDetailsViewModel = new ShippingDetailsViewModel
            {
                ShippingDetails = new ShippingDetails()
            };
            return View(shippingDetailsViewModel);
        }

        [HttpPost]
        public IActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", String.Format("Thank you {0}, your order is in process",shippingDetails.FirstName));
            return View();
        }
    }
}