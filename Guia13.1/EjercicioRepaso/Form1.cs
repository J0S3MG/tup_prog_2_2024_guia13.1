using EjercicioRepaso.Models;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace EjercicioRepaso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Agencia a; //Creo la ruta donde se va alamcenar mi objeto "COntenedor".
        string path = Application.StartupPath + "\\Agencia.dat";
        #region Persistencia
        private void Form1_Load(object sender, EventArgs e)//Este es el evento de carga de la aplicacion.
        {
            FileStream fs = null;//Creo un filestream nulo.
            try//Hago un try por lo que pueda pasar. 
            {
                if (File.Exists(path))//Chequeo que la ruta exista
                {   //Si existe hago la deserializacion
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);//Abro el archivo con la ruta creada anteriormente.
                    BinaryFormatter bf = new BinaryFormatter();//Creo el bf para hacer la deserializacion.
                    a = bf.Deserialize(fs) as Agencia;//Casteo el fs para que sea una agencia el objeto que me devuelva.
                }
                else if (a == null) //Caso contrario consulto si a esta vacio es decir As devuelve nulo xq el fs esta vacio.
                {                  //Solo pasa si es la primera vez que se ejecuta el codigo o si alguien borra el archivo o su contenido.
                     a = new Agencia();//Creo la agencia 
                }
            }
            finally //Pongo un bloque finally donde cierro fs.
            {
                if (fs != null) fs.Close();//Me aseguro que fs tenga algo para poder cerrarlo. 
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)//Este es el evento de cierre de la aplicacion.
        {
            FileStream fs = null;//Creo un filestream nulo.
            try//Hago un try por lo que pueda pasar. 
            {
                if (File.Exists(path))//Chequeo que la ruta exista.
                { //Si existe la borro para "actualizar el archivo" por medio de la serializacion.
                    File.Delete(path);
                }
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);//Abro el archivo con la ruta creada anteriormente.
                BinaryFormatter bf = new BinaryFormatter();//Creo el bf para hacer la serializacion.
                bf.Serialize(fs, a);//Hago la serializacion pasando el archivo y el objeto contenedor. 
            }
            finally //Pongo un bloque finally donde cierro fs.
            {
                if (fs != null) fs.Close();//Me aseguro que fs tenga algo para poder cerrarlo. 
            }
        }
        #endregion
        #region Caso Registrar Turno
        private void btnTicket_Click(object sender, EventArgs e)
        {
            try//Hacemo un try para atrapar una excepcion personalizada o general.
            {
                Ticket turno = null;//Creamos un ticket nulo para jugar con el polimorfismo.
                #region Caso Denuncia
                if (rbnDenuncia.Checked)//Chequeamos que hagan click en el primer radiobuton.
                {
                    string patente = tbxPatente.Text;//Leemos el texbox
                    Vehiculo v = a[patente];//Jugamos con el encapsulamiento y buscamos un vehiculo.
                    if (v != null)
                    {//Si existe creamos la denuncia y limpiamos el texbox.
                        turno = new Denuncia(v);
                        tbxPatente.Clear();
                    }
                    else
                    {//Sino lanzamos un mensaje. 
                        MessageBox.Show("El vehículo no pertenece a la agencia.");
                    }
                }
                #endregion
                #region Caso Cliente
                else if (rbnCliente.Checked)//Chequeamos que hagan click en el segundo radiobuton.
                {  
                    string dni = tbxDNI.Text;//Leemos el texbox
                    int tipo = cbxTipo.SelectedIndex+1;//SelectedIndex retorna 0 asi que sumamos 1 para cumplir con el enunciado.
                    turno = new Cliente(dni,tipo);//Creamos el ticket de cliente. //(1- Auto, 2-Moto, 3- Equipo de trabajo,4- Bicicleta).
                    tbxDNI.Clear();//Limpiamos el texbox.
                }
                else
                {//Lanzamos un mensaje en caso de que no haya hecho click sobre ninguno. 
                    MessageBox.Show("Elija el tipo de ticket!");
                }
                #endregion
                a.AgregarTicket(turno);//Lo agregamos a su respectiva cola utilizando polimorfismo y encapsulamiento.
                listBox1.Items.Add(turno);//Lo agregamos al lisbox.
            }
            catch (DNIException ex)//Tratamos la excepcion personalizada.
            {
                MessageBox.Show(ex.Message, "DNI No válido");
            }
            catch (Exception ex)//tratamos las excepciones generales.
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion
        #region Casos Atender Clientes y Denuncias
        private void btnAtenderD_Click(object sender, EventArgs e)
        {
            Ticket turno = a.AtenderTicket(1);
            if (turno != null)
            {
                listBox1.Items.Remove(turno);
            }
        }

        private void btnAtenderC_Click(object sender, EventArgs e)
        {
            Ticket turno = a.AtenderTicket(2);
            if (turno != null)
            {
                listBox1.Items.Remove(turno);
            }
        }
        #endregion

    }
}
