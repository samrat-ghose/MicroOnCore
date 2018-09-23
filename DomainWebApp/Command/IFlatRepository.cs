using System.Threading.Tasks;
using DomainWebApp.Domain;
using Microsoft.eShopOnContainers.Services.Ordering.Domain.Seedwork;

namespace DomainWebApp.Command
{
    public interface IFlatRepository:IRepository<Flat>
    {
        void Add(Flat flat);
        Task<bool> SaveEntitiesAsync();
    }
}