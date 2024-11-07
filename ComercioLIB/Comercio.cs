using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLIB
{
    public class Comercio
    {
        List<CuentaCorriente> cuentasCorrientes = new List<CuentaCorriente>();
        Queue<Pago> NuevosPagos = new Queue<Pago>();
        Queue<Cliente> NuevosClientes = new Queue<Cliente>();
        List<Ticket> ListaAtendidos = new List<Ticket>();

        public void AgregarTicket(Ticket turno)
        {
            if (turno is Pago)
            {
                NuevosPagos.Enqueue((Pago)turno);
            }
            if (turno is Cliente)
            { 
                NuevosClientes.Enqueue((Cliente)turno);
            }
        }
        public void AtenderTicket(int tipoTicket)
        { 
            Ticket p=null;
            if (tipoTicket == 0)
            {
                if (NuevosPagos.Count > 0)
                {
                    p = NuevosPagos.Dequeue();
                    ListaAtendidos.Add(p);
                }
            }
            else if (tipoTicket == 1)
            {

                if (NuevosClientes.Count > 0)
                {
                    p = NuevosClientes.Dequeue();
                    ListaAtendidos.Add(p);
                }
            }
        }

        public List<Ticket> VerTickets()
        {
            return ListaAtendidos;
        }
       
        public void CrearCtaCte(int cta, Cliente nuevo)
        {
            cuentasCorrientes.Add(new CuentaCorriente(cta, nuevo));
        }

        public CuentaCorriente PedirCuenta(int nrocuenta)
        {
            cuentasCorrientes.Sort();
            int idx = cuentasCorrientes.BinarySearch(new CuentaCorriente(nrocuenta, null));
            if (idx > 0 )
                return cuentasCorrientes[idx];
            return null;
        }
    }
}
