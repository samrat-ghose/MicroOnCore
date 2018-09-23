using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainWebApp.Domain;
using MediatR;

namespace DomainWebApp.DomainEvents
{
    public class MovedOutDomainEvent : INotification
    {
        private Flat flat;

        public MovedOutDomainEvent(Flat flat)
        {
            this.flat = flat;
        }
    }
}
