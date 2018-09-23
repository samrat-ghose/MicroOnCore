using DomainWebApp.Controllers;
using DomainWebApp.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DomainWebApp.Command
{
    public class MoveInCommandHandler
       : IRequestHandler<MoveInCommand, bool>
    {
        private readonly IFlatRepository _flatRepository;
        
        private readonly IMediator _mediator;

        // Using DI to inject infrastructure persistence Repositories
        public MoveInCommandHandler
            (IMediator mediator, IFlatRepository flatRepository)
        {
            _flatRepository = _flatRepository ?? throw new ArgumentNullException(nameof(flatRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        public async Task<bool> Handle(MoveInCommand message, CancellationToken cancellationToken)
        {
            // Add/Update the Buyer AggregateRoot
            // DDD patterns comment: Add child entities and value-objects through the Order Aggregate-Root
            // methods and constructor so validations, invariants and business logic 
            // make sure that consistency is preserved across the whole aggregate
            Flat flat = new Flat(message.flatNo);

            flat.MoveIn(message.List);

            _flatRepository.Add(flat);

            return await _flatRepository
                .SaveEntitiesAsync();

           
        }
    }
}
