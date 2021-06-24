using System.Collections.Generic;
using MediatR;
using Skol.Domain.Models;

namespace Skol.Application.Orders.Commands
{
    public class CreateOrder : IRequest<Order>
    {
        public record OrderedItem(string Code, int Quantity);

        public List<OrderedItem> Items { get; init; } = new List<OrderedItem>();
        public decimal? Discount { get; init; } = 0;
    }
}