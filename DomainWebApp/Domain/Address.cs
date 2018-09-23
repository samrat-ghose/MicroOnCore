using System.Collections.Generic;
using Microsoft.eShopOnContainers.Services.Ordering.Domain.SeedWork;

namespace DomainWebApp.Domain
{
    public class Address : ValueObject
    {
        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new System.NotImplementedException();
        }
    }
}