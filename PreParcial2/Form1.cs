using PreParcial2.Models;
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

namespace PreParcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AgenciaControllers Ag = new AgenciaControllers();

        private void btnTicket_Click(object sender, EventArgs e)
        {
            if (rbtnDenuncia.Checked)
            { 
                string patente = txbPatente.Text;

                Vehiculo v = Ag[patente];

            }

            else if (rbtnNuevo.Checked)
            {
                long dni = Convert.ToInt32(txbDNI.Text);

            }
        }

        private void btnNuevoC_Click(object sender, EventArgs e)
        {
            //Ticket ticket = Ag.AtenderTicket(0);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream libro = null;
            try
            {
                libro = new FileStream("agencia.dat", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter escritor = new BinaryFormatter();
                Ag = escritor.Deserialize(libro) as AgenciaControllers;
            }
            catch { }
            finally
            {
                if (libro != null) { libro.Close(); }
            }

            if ( Ag == null)
            {
                Ag = new AgenciaControllers();

                Ag.AgregarVehiculo("ABC123", 45312756);
                Ag.AgregarVehiculo("ABC345", 35122536);
                Ag.AgregarVehiculo("AAA111", 33666336);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream libro = null;
            try
            {
                libro = new FileStream("agencia.dat", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter escritor = new BinaryFormatter();
                escritor.Serialize(libro, Ag);
            }
            catch { }
            finally 
            {
                if (libro != null) 
                { libro.Close(); } 
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Exportando los archivos";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = saveFileDialog1.FileName;

                FileStream libro = null;
                StreamWriter escritor = null;

                try
                {
                    libro = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Write);

                    escritor = new StreamWriter(libro);

                    string linea = "Tipo:DENUNCIA;NroTicket;Fecha;Patente";
                    escritor.WriteLine(linea);
                    linea = "Tipo:CLIENTE;NroTicket;Fecha;Patente";
                    escritor.WriteLine(linea);

                    foreach (Ticket ticket in Ag.ListaAtendidos)
                    {
                        linea = ticket.ToString();
                        escritor.WriteLine(linea);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en la exportación");
                }
                finally
                {
                    if (escritor != null) escritor.Close();
                    if (libro != null) libro.Close();
                }
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Importando Vehiculos";
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                string ruta = openFileDialog1.FileName;

                FileStream libro = null;
                StreamReader lector = null;
                
                try
                {
                    libro = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);

                    lector = new StreamReader(libro);

                    while (lector.EndOfStream == false)
                    {
                        string linea = lector.ReadLine();

                        string[] separá = linea.Split(';');

                        string nroPatente = separá[0];
                        int dniDueño = Convert.ToInt32(separá[1]);

                        Ag.AgregarVehiculo(nroPatente, dniDueño);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en la importación");
                }

                if (lector != null) lector.Close();
                if (libro != null) libro.Close();
                
                
            }
        }
    }
}
