using DomainWebApp.Domain;

namespace Microsoft.eShopOnContainers.Services.Ordering.Domain.Seedwork
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        
    }
}
