using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Skol.Application.Orders.Commands;

namespace Skol.Application.Bartenders.Triggers
{
    public class OrderReceivedHandler : INotificationHandler<StateChangeNotification<OrderReceived>>
    {
        public async Task Handle(StateChangeNotification<OrderReceived> notification, CancellationToken cancellationToken = default)
        {
            Console.WriteLine($"Order received: {notification.StateChangeEntry.OccurredAsOf}");

            await Task.CompletedTask;
        }
    }
}