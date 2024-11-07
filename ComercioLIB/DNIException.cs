using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLIB
{
    internal class DNIException : ApplicationException
    {
        public DNIException()  : base () { }
        public DNIException(string ex) : base(ex) { }
        public DNIException(string ex, Exception innerException) : base(ex, innerException) { }

    }
}
