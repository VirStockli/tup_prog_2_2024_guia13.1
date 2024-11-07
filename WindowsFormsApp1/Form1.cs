using ComercioLIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
            listBox1.Items.Clear();
            if (cbxNroCta.Checked)
            {
                int nrocuenta = Convert.ToInt32(txbCtaCte.Text);
                CuentaCorriente cc = c.PedirCuenta(nrocuenta);
                Ticket p = new Pago(cc);
                c.AgregarTicket(p);
                listBox1.Items.Add(p);
            }
            else if (!cbxNroCta.Checked)
            {
                string dni = txbDNI.Text;
                Ticket cl = new Cliente(dni);
                c.AgregarTicket(cl);
                listBox1.Items.Add(cl);
            }
            
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

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

            List<Ticket> ticks = c.VerTickets();
            int idx = ticks.Count;

            listBox1.Items.Add(ticks[idx]);

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

            if (GuardarDoc.ShowDialog() == DialogResult.OK)
            {
                FileStream libro = null;
                StreamWriter escritor = null;
                try
                {
                    string ruta = GuardarDoc.FileName;

                    libro = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Write);
                    escritor = new StreamWriter(libro);

                    //añadí un método para acceder a la lista de tickets

                    List<Ticket> tick = c.VerTickets();

                    foreach (Ticket t in tick)
                    {
                        escritor.WriteLine(tick.ToString());
                    }
                }

                catch { }
                finally
                {
                    if (escritor != null) escritor.Close();
                    if (libro != null) libro.Close();
                }
            }

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (AbrirDoc.ShowDialog() == DialogResult.OK)
            {
                FileStream libro = null;
                StreamReader lector = null;
                try
                {
                    string ruta = AbrirDoc.FileName;

                    libro = new FileStream("CtaCte.csv", FileMode.Open, FileAccess.Read);
                    
                    lector = new StreamReader(libro);

                    while (!lector.EndOfStream)
                    {
                        string linea = lector.ReadLine();

                        string[] columnas = linea.Split(';');

                        int NroCuenta = Convert.ToInt32(columnas[0]);
                        string dni = columnas[1];
                        double saldo = Convert.ToDouble(columnas[2]);
                        
                        CuentaCorriente cta = null;
                        cta = c.PedirCuenta(NroCuenta);
                        if (cta == null)
                        {
                           //Acá agregué un método que cree CuentasCorrientes
                            Cliente nuevo = new Cliente(dni);
                            c.CrearCtaCte(NroCuenta, nuevo);
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "DNI inválido");
                }
                finally
                {
                    if (lector != null) lector.Close();
                    if (libro != null) libro.Close();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream libro = null;
            try
            {
                libro = new FileStream("Comercio.dat", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter maquina = new BinaryFormatter();
                maquina.Serialize(libro, c);
            }
            catch { }
            finally
            {
                if (libro != null)
                { libro.Close(); }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream libro = null;
            try
            {
                libro = new FileStream("agencia.dat", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter escritor = new BinaryFormatter();
                c = escritor.Deserialize(libro) as Comercio;
            }
            catch { }
            finally
            {
                if (libro != null) { libro.Close(); }
            }

            if (c == null)
            {
                c = new Comercio();
                Cliente nuevo = new Cliente("45312756");
                c.CrearCtaCte(1234123456, nuevo);
                Cliente nu = new Cliente("35122536");
                c.CrearCtaCte(313145612, nu);
                Cliente evo = new Cliente("33666336");
                c.CrearCtaCte(653211234, evo);

            }

        }
    }
}