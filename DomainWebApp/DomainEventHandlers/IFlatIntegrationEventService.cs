using System.Threading.Tasks;

namespace DomainWebApp.DomainEventHandlers
{
    public interface IFlatIntegrationEventService
    {
         Task  PublishThroughEventBusAsync(MovedInIntegrationEvent orderStatusChangedToCancelledIntegrationEvent);
    }

    public class FlatIntegrationEventService : IFlatIntegrationEventService
    {
        

        public FlatIntegrationEventService()
        {

        }
        public Task PublishThroughEventBusAsync(MovedInIntegrationEvent orderStatusChangedToCancelledIntegrationEvent)
        {
            throw new System.NotImplementedException();
        }
    }
}