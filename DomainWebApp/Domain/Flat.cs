using DomainWebApp.Exceptions;
using Microsoft.eShopOnContainers.Services.Ordering.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainWebApp.Domain
{
    public class Flat:Entity,IAggregateRoot
    {
        private int _flatNumber;
        private string _facing;
        private List<Occupant> _occupants;
        private int _rent;
        private int _deposit;

        public Flat(int flatNumber, string facing,int rent, int deposit)
        {
            _flatNumber = flatNumber;
            _facing = facing;
            _rent = rent;
            _deposit = deposit;
        }

        public Flat(int flatNumber):this(flatNumber,"East",10000,50000)
        {

        }

        

        public IReadOnlyCollection<Occupant> Occupants { get => _occupants.AsReadOnly();  }

        public void MoveIn(List<Occupant> occupants)
        {
            _occupants = occupants;
        }

        public void MoveOut()
        {
            _occupants.Clear();
            AddDomainEvent(new DomainEvents.MovedOutDomainEvent(this));

        }

        public void AddOccupant(Occupant occupant)
        {
            _occupants.Add(occupant);
            AddDomainEvent(new DomainEvents.NewOccupantDomainEvent(this,occupant));

        }

        public void ChangeRent(int rent)
        {
            if( rent < _rent || rent == 0)
            {
                throw new FlatDomainException();
            }
            _rent = rent;
            AddDomainEvent(new DomainEvents.RentChangedDomainEvent(this, rent));
        }

    }
}
