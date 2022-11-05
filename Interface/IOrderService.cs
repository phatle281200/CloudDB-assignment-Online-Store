﻿using Online_Store.DTO;
using Online_Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Store.Interface
{
    public interface IOrderService
    {
        Task<List<Order>> GetOrders();
        Task<Order> GetSingleOrderById(Guid id);
        Task AddOrder(CreateOrderDTO order);
        Task UpdateOrderById(Guid id, Order order);
        Task DeleteSingleOrderById(Guid id);
        ICollection<Product> GetMultipleProducts(ICollection<Guid> products);
    }
}
