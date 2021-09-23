using Microsoft.EntityFrameworkCore;
using Store_1.Application.Interfaces.Context;
using Store_1.Common.Dto;
using Store_1.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Application.Services.Orders.Queries.GetOrdersForAdmin
{
    public interface IGetOrdersForAdminService
    {
        ResultDto<List<OrdersDto>> Execute(orderState orderState);
    }
    public class GetOrdersForAdminService: IGetOrdersForAdminService
    {
        private readonly IDataBaseContext _context;
        public GetOrdersForAdminService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<OrdersDto>> Execute(orderState orderState)
        {
            var orders = _context.Orders.Include(p => p.OrderDetails).Where(p => p.orderState == orderState)
                .OrderByDescending(p => p.Id).ToList().Select(p => new OrdersDto
                {
                    InsetTime = p.InsertTime,
                    OrderId = p.Id,
                    orderState = p.orderState,
                    ProductCount = p.OrderDetails.Count(),
                    RequestId = p.RequestPayId,
                    UserId = p.UserId,
                }).ToList();
            return new ResultDto<List<OrdersDto>>()
            {
                Data = orders,
                IsSuccess = true,
            };
        }
    }
    public class OrdersDto
    {
        public long OrderId { get; set; }
        public DateTime InsetTime { get; set; }

        public long RequestId { get; set; }
        public long UserId { get; set; }
        public orderState orderState { get; set; }
        public int ProductCount { get; set; }
    }
}
