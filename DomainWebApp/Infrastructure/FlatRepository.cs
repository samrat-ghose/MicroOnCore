using DomainWebApp.Command;
using DomainWebApp.Domain;
using Microsoft.eShopOnContainers.Services.Ordering.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainWebApp.Infrastructure
{
    public class FlatRepository : IFlatRepository
    {
        public void Add(Flat flat)
        {
            
        }

        public Task<bool> SaveEntitiesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
