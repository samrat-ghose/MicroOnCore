using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainWebApp.Domain;
using MediatR;

namespace DomainWebApp.DomainEvents
{
    public class NewOccupantDomainEvent : INotification
    {
        private Flat flat;
        private readonly Occupant occupant;

        public NewOccupantDomainEvent(Flat flat, Occupant occupant)
        {
            this.flat = flat;
            this.occupant = occupant;
        }
    }
}
