using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLIB
{
    public class Cliente : Ticket
    {
        static int nroInicio;

        public int dni;

        public Cliente(string dni) 
        {
            int dNI = Convert.ToInt32(dni);
          if (dNI < 30000000 && dNI>45000000)
            {
                throw new DNIException("Dni no válido");
            }
          this.dni = dNI;
          nroOrden = nroInicio++;
        }

        public override string ToString()
        {
            return $"C;{nroInicio};{dni}";
        }
    }
}
