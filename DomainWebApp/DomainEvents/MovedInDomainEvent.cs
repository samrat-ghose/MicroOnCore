using DomainWebApp.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainWebApp.DomainEvents
{
    public class MovedInDomainEvent:INotification
    {
        public MovedInDomainEvent(int flatNo,List<Occupant> occupants )
        {
            FlatNo = flatNo;
            Occupants = occupants;
        }

        public int FlatNo { get; }
        public List<Occupant> Occupants { get; }
    }
}
