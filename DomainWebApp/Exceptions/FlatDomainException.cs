using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainWebApp.Exceptions
{
    public class FlatDomainException:Exception
    {
        public FlatDomainException()
        { }

        public FlatDomainException(string message)
            : base(message)
        { }

        public FlatDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
