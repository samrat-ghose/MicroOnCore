using DomainWebApp.DomainEvents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DomainWebApp.DomainEventHandlers
{
    public class MovedInDomainEventHandler : INotificationHandler<MovedInDomainEvent>
    {
        
        private readonly IFlatIntegrationEventService _flatIntegrationEventService;

        public MovedInDomainEventHandler(
            IFlatIntegrationEventService flatIntegrationEventService)
        {
            _flatIntegrationEventService = flatIntegrationEventService;
        }

        public Task Handle(MovedInDomainEvent notification, CancellationToken cancellationToken)
        {
            var orderStatusChangedToCancelledIntegrationEvent = new MovedInIntegrationEvent(notification.FlatNo);
            return  _flatIntegrationEventService.PublishThroughEventBusAsync(orderStatusChangedToCancelledIntegrationEvent);
        }

       
    }
}
