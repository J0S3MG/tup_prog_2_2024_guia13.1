using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.Models
{
    public class Agencia
    {
        #region Hago las colas de clientes y denuncias
        Queue<Cliente> nuevoC = new Queue<Cliente>();
        Queue<Denuncia> nuevoD = new Queue<Denuncia>();
        #endregion
        #region Hago la lista de vehiculos y de atendidos
        List<Vehiculo> ListaV = new List<Vehiculo>();
        List<Ticket> ListaAt = new List<Ticket>();
        #endregion
        #region Busco el Vehiculo
        public Vehiculo this[string patente]//Hago un indexador para buscar el vehiculo.
        {
            get
            {
                ListaV.Sort();
                Vehiculo v = new Vehiculo(null,patente);
                int idx = ListaV.BinarySearch(v);
                if (idx >= 0)// Si la busqueda devuelve 0 o mas. 
                    return ListaV[idx];//retorno el valor almacenado en esa pocision.
                return null;//Sino retorno null xq no lo encotro quiere decir que no existe.
            }
        }
        #endregion
        public void AgregarTicket(Ticket t)//Agrego el ticket.
        {
            if (t is Cliente c)//Utilizo el IS para saber si t es cliente.
            {         //Si lo es lo agrego a la cola.
                nuevoC.Enqueue(c);
            }
            else if (t is Denuncia d)//Aqui hago lo mismo que en el de arriba.
            { 
              nuevoD.Enqueue(d); 
            }
        }
        public Ticket AtenderTicket(int tipo)
        {
            Ticket t = null;//Volvemos a jugar con el polimorfismo.
            if(tipo == 1)//Segun el numero elimina de una cola u otra.
            {
                t = nuevoD.Dequeue();//Nos retorna el elemento eliminado.
            }
            else if (tipo == 2)
            {
                t = nuevoC.Dequeue();
            }
            return t;//retornamos el valor eliminado para poder eliminarlo del listBox.
        }
        public List<Ticket> RetornoLaListaPrivada()//Hice este metodo para poder usar el foreach.
        {//Necesito que me retorne la lista xq al ser privada no puedo acceder a ella.
            return ListaAt;
        }
        
        public void AgregarVehiculo(string nroPantente, string dniDueño)//A este método lo nececito! para la importación.
        {
            Vehiculo nuevo = this[nroPantente];//Me fijo que el vehiculo no exista.

            if (nuevo == null)//Si no existe lo creo y lo agrego a la lista.
            {
                Cliente cliente = new Cliente(dniDueño,0);
                nuevo = new Vehiculo(cliente,nroPantente);
                ListaV.Add(nuevo);
            }
        }
    }
}
