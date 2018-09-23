using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainWebApp.Domain;
using MediatR;

namespace DomainWebApp.DomainEvents
{
    public class RentChangedDomainEvent : INotification
    {
        private Flat flat;
        private int rent;

        public RentChangedDomainEvent(Flat flat, int rent)
        {
            this.flat = flat;
            this.rent = rent;
        }
    }
}
