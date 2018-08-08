using System;
using DShop.Common.Types;
using DShop.Services.Orders.Dtos;

namespace DShop.Services.Orders.Queries
{
    public class BrowseOrders : PagedQueryBase, IQuery<PagedResult<OrderDto>>
    {
        public Guid CustomerId { get; set; }
    }
}