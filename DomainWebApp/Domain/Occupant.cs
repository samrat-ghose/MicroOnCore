using Microsoft.eShopOnContainers.Services.Ordering.Domain.Seedwork;

namespace DomainWebApp.Domain
{
    public class Occupant:Entity
    {
        private string _name;
        private int _age;
        private Address _permanentAddress;

        public Occupant(string name, int age, Address address)
        {
            _permanentAddress = address;
        }

        
    }
}
