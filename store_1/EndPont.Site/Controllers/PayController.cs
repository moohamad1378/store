using Dto.Payment;
using EndPont.Site.Utilties;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store_1.Application.Services.Carts;
using Store_1.Application.Services.Fainances.Commands.AddRequestPay;
using Store_1.Application.Services.Fainances.Queries.GetRequestPayService;
using Store_1.Application.Services.Orders.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZarinPal.Class;

namespace EndPont.Site.Controllers
{
    [Authorize("Customer")]
    // با کد بالا مشخص میکنیم کدوم کاربر ها اجازه استفاده از پی کنترلر رو دارن
    public class PayController : Controller
    {
        private readonly IAddRequestPayService _addRequestPayService;
        private readonly ICartService _cartService;
        private readonly CookiesManeger _cookiesManeger;
        private readonly Payment _payment;
        private readonly Authority _authority;
        private readonly Transactions _transactions;
        private readonly IGetRequestPayService _getRequestPayService;
        private readonly IAddNewOrderService _addNewOrderService;

        public PayController(IAddRequestPayService addRequestPayService,ICartService cartService
            ,IGetRequestPayService getRequestPayService , IAddNewOrderService addNewOrderService)
        {
            _addRequestPayService = addRequestPayService;
            _cartService = cartService;
            _cookiesManeger = new CookiesManeger();
            var expose = new Expose();
            _payment = expose.CreatePayment();
            _authority = expose.CreateAuthority();
            _transactions = expose.CreateTransactions();

            _getRequestPayService = getRequestPayService;
            _addNewOrderService = addNewOrderService;
            
        }
        public async Task<IActionResult>  Index()
        {
            long? UserId= ClaimUtility.GetUserId(User);
            var cart = _cartService.GetMyCart(_cookiesManeger.GetBrowserId(HttpContext), UserId);
            if(cart.Data.SumAmount > 0)
            {
                var requestPay = _addRequestPayService.Execute(cart.Data.SumAmount, UserId.Value);
                //بعد از اینها ارسا میشه به درگاه پرداخت



                var result = await _payment.Request(new DtoRequest()
                {
                    Mobile = "09121112222",
                    CallbackUrl = $"https://localhost:44358/Pay/Verify?guid={requestPay.Data.guid}",
                    // چی یو آیدی رو برای درگاه بانک میفرستیم و وقتی بانک کاربر رو به سمت سایت هدایت میکنه این رو ازیش میگیریم
                    Description = "  پرداخت فاکتور شماره  " + requestPay.Data.RequestPayid,
                    Email = requestPay.Data.Email,
                    Amount = requestPay.Data.Amount,
                    MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX"
                }, ZarinPal.Class.Payment.Mode.sandbox);
                return Redirect($"https://sandbox.zarinpal.com/pg/StartPay/{result.Authority}");
            }
            else
            {
                return RedirectToAction("Index", "Cart");
            }
            


            //return View();
        }
        public async Task<IActionResult> Verify(Guid guid, string authority, string status)
        {
            var requestPay = _getRequestPayService.Execute(guid);
            var verification = await _payment.Verification(new DtoVerification
            {
                Amount =requestPay.Data.Amount,
                MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                Authority = authority
            }, Payment.Mode.sandbox);

            long? UserId = ClaimUtility.GetUserId(User);
            var cart = _cartService.GetMyCart(_cookiesManeger.GetBrowserId(HttpContext),UserId);
            //با کد بالا صبد خرید رو میگیریم
            if (verification.Status == 100)
            {
                _addNewOrderService.Execute(new RequestaddNewOrderServiceDto
                {
                    CartId = cart.Data.CartId,
                    UserId = UserId.Value,
                    RequestPayId = requestPay.Data.Id,
                });
                return RedirectToAction("Index", "Orders");
            }
            else
            {

            }
            return View();
        }
    }
}
