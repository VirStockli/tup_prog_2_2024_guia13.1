using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLIB
{
    public class CuentaCorriente : IComparable<CuentaCorriente>
    {
        private int NroCuenta;
        private Cliente titular;
        private double saldo;

        public CuentaCorriente (int nroCuenta, Cliente titular)
        {
            NroCuenta = nroCuenta;
            this.titular = titular;
        }
        public Cliente VerTitular()
        { 
            return titular;
        }

        public int VerNroCuenta()
        {
            return this.NroCuenta;
        }

        public void RegistrarPago(double monto)
        { this.saldo -= monto; }
        public void RegistrarCompra(double monto)
        { this.saldo += monto; }

        public double VerSaldo()
        {
            return saldo;
        }
        public int CompareTo(CuentaCorriente other)
        {
            if (other != null)
                return NroCuenta.CompareTo(other.NroCuenta);
            return 1;
        }

        public override string ToString()
        {
            return $"{NroCuenta};{saldo}";
        }
    }
}
