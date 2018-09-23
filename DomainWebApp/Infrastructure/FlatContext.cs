using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Ordering.Infrastructure;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.eShopOnContainers.Services.Ordering.Infrastructure
{
    public class FlatContext : DbContext
    {
        private readonly IMediator _mediator;

        private FlatContext(DbContextOptions<FlatContext> options) : base (options) { }

        public FlatContext(DbContextOptions<FlatContext> options, IMediator mediator) : base(options)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));


            System.Diagnostics.Debug.WriteLine("OrderingContext::ctor ->" + this.GetHashCode());
        }

      
        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            await _mediator.DispatchDomainEventsAsync(this);

            return true;
        }        
    }

  
}
