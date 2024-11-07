using ComercioLIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Comercio c = new Comercio();
        private void btnTicket_Click(object sender, EventArgs e)
        {
            if (cbxNroCta.Checked)
            {
                int nrocuenta = Convert.ToInt32(txbCtaCte.Text);
                CuentaCorriente cc = c.PedirCuenta(nrocuenta);
                Ticket p = new Pago(cc);
                c.AgregarTicket(p);
            }
            else if (!cbxNroCta.Checked)
            {
                string dni = txbDNI.Text;
                Ticket cl = new Cliente(dni);
                c.AgregarTicket(cl);
            }
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (rbtnCompra.Checked)
            {
                int n = 0;
                c.AtenderTicket(n);
            }
            if (rbtnPago.Checked)
            {
                int n = 1;
                c.AtenderTicket(n);
            }
        }
    }
}