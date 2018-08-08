﻿using System;
using System.Collections.Generic;
using static DShop.Services.Orders.Domain.Order;

namespace DShop.Services.Orders.Dtos
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public long Number { get; set; }
        public int ItemsCount { get; set; }
        public decimal TotalAmount { get; set; }
        public string Currency { get; set; }
        public OrderStatus Status { get; set; }
    }
}
