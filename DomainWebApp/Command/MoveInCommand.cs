using DomainWebApp.Domain;
using MediatR;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DomainWebApp.Controllers
{
    [DataContract]
    public class MoveInCommand:IRequest<bool>
    {
      
            public MoveInCommand (List<Occupant> list)
            {
            List = list;
        }

        [DataMember]
        public List<Occupant> List { get; }

        [DataMember]
        public int flatNo { get; }
    }
}