using Parcial_2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Comercio liam = new Comercio();
        string path = Application.StartupPath + "Datos.Bin";
        #region Persistencia.
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    liam = bf.Deserialize(fs) as Comercio;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (fs != null) fs.Close();
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, liam);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
        #endregion
        #region Caso Solicitar Ticket.
        private void btnTicket_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket turno = null;
                if (cbxNroCtaCte.Checked)
                {
                    int nroCC = Convert.ToInt32(tbxNroCtaCte.Text);
                    CtaCte c = liam.VerCuentaCorriente(nroCC);
                    if (c != null)
                        turno = new Pago(c);
                }
                else
                {
                    string dni = tbxDNI.Text;
                    turno = new Cliente(dni);
                }
                liam.AgregarTicket(turno);
                lbxTurnos.Items.Add(turno);
            }
            catch (DNIException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Caso Arender Ticket.
        private void btnAtender_Click(object sender, EventArgs e)
        {
            Ticket turno = null;
            if (rbxCliente.Checked)
            {
                turno = liam.AtenderTicket(1);
            }
            else if (rbxPago.Checked)
            {
                turno = liam.AtenderTicket(2);
            }
            if (turno != null)
                lbxTurnos.Items.Remove(turno);
        }


        #endregion
        #region Importar CtaCte.
        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog imp = new OpenFileDialog();
            imp.Filter = "fichero csv|*.csv";
            if (imp.ShowDialog() == DialogResult.OK)
            {
                string ruta = imp.FileName;
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string linea = sr.ReadLine();
                    while (sr.EndOfStream == false)
                    {
                        linea = sr.ReadLine();
                        CtaCte c = new CtaCte();
                        c.Leer(linea);
                        Cliente titular = new Cliente();
                        titular.Leer(linea);
                        CtaCte cuenta = liam.AgregarCtaCte(c.VerNro(), titular.VerDni());
                        MessageBox.Show("La Cuenta se agrego correctamente: "+ cuenta.ToString());
                    } 
                }
                catch (DNIException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
            }
        }
        #endregion
        #region Exportar Tickets.
        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog exp = new SaveFileDialog();
            exp.Filter = "fichero csv|*.csv";
            if (exp.ShowDialog() == DialogResult.OK)
            {
                string ruta = exp.FileName;
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    sw.WriteLine("tipo;numero;dni;ctaCte");
                    List<Ticket> atendidos = liam.VerAtendidos();
                    for(int i = 0; i < atendidos.Count; i++)
                    {
                        Ticket turno = atendidos[i];
                        sw.WriteLine($"{turno.Escribir()}");
                    }
                    MessageBox.Show("Exportacion hecha correctamente");
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
        }
        #endregion
    }
}
