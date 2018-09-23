namespace DomainWebApp.DomainEventHandlers
{
    public class MovedInIntegrationEvent
    {
        private int flatNo;

        public MovedInIntegrationEvent(int flatNo)
        {
            this.flatNo = flatNo;
        }
    }
}