using Microsoft.EntityFrameworkCore;
using Store_1.Application.Interfaces.Context;
using Store_1.Common.Dto;
using Store_1.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Application.Services.Orders.Commands
{
    public interface IAddNewOrderService
    {
        ResultDto Execute(RequestaddNewOrderServiceDto request);
    }
    public class AddNewOrderService : IAddNewOrderService
    {
        private readonly IDataBaseContext _context;
        public AddNewOrderService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestaddNewOrderServiceDto request)
        {
            var user = _context.users.Find(request.UserId);
            var requsetPay = _context.RequestPays.Find(request.RequestPayId);
            var cart = _context.Carts.Include(p => p.CartItems)
                .ThenInclude(p=>p.Product)
                .Where(p => p.Id == request.CartId).FirstOrDefault();
            //با کد بالا سبد خرید رو فایند میکنیم
            requsetPay.IsPay = true;
            requsetPay.PayDate = DateTime.Now;
            requsetPay.RefId = request.RefId;
            requsetPay.Authurity = requsetPay.Authurity;

            cart.Finished = true;
            Order order = new Order()
            {
                Address = "",
                orderState = orderState.Processing,
                RequestPay = requsetPay,
                User = user,
            };
            _context.Orders.Add(order);


            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach (var item in cart.CartItems)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    Count = item.Count,
                    Order = order,
                    Price = item.Product.Price,
                    Product = item.Product,

                };
                orderDetails.Add(orderDetail);
            }
            _context.OrderDetails.AddRange(orderDetails);
            _context.SaveChanges();
            return new ResultDto()
            {
                IsSuccess = true,
                Message = "",
            };
        }
    }
    public class RequestaddNewOrderServiceDto
    {
        public long CartId { get; set; }
        public long RequestPayId { get; set; }

        public long UserId { get; set; }
        public string Authority { get; set; }
        public long RefId { get; set; }
    }
}
