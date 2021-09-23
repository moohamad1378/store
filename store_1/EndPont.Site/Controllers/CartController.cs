using EndPont.Site.Utilties;
using Microsoft.AspNetCore.Mvc;
using Store_1.Application.Services.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPont.Site.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly CookiesManeger _cookiesManeger;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
            _cookiesManeger = new CookiesManeger();
        }
        public IActionResult Index()
        {//صفحه سبد خرید
            var userId= ClaimUtility.GetUserId(User);
            var resultGetList= _cartService.GetMyCart(_cookiesManeger.GetBrowserId(HttpContext), userId);
            return View(resultGetList.Data);
        }

        public IActionResult AddToCart(long ProductId)
        {
            
            
            var redsultDto = _cartService.AddToCart(ProductId, _cookiesManeger.GetBrowserId(HttpContext));

            return RedirectToAction("Index");
        }
        public IActionResult Add(long CartItemId)
        {
            _cartService.Add(CartItemId);

            return RedirectToAction("Index");
        }

        public IActionResult LowOff(long CartItemId)
        {
            _cartService.LowOff(CartItemId);

            return RedirectToAction("Index");
        }
        public IActionResult Remove(long ProductId)
        {
            _cartService.RemoveFromCart(ProductId, _cookiesManeger.GetBrowserId(HttpContext));
            return RedirectToAction("Index");
        }

    }

}
