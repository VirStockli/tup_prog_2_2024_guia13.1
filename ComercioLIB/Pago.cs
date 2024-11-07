using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLIB
{
    public class Pago : Ticket
    {
        static int nroInicio;
        private CuentaCorriente cc;
        public Pago(CuentaCorriente cc)
        {
            this.cc = cc;
            nroOrden = nroInicio++;
        }
        public void MontoPago(double valor)
        {
            cc.RegistrarPago(valor);
        }
    }
}
