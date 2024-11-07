using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLIB
{
    public abstract class Ticket
    {
        protected int nroOrden;

        private DateTime fechaHora;

        public int VerNro()
        {
            return nroOrden;
        }

        public DateTime VerFecha()
        {
            return fechaHora;                
        }

        public override string ToString()
        {
            return $"{fechaHora.Date}";
        }

    }
}
