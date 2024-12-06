using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2.Models
{
    public class Comercio
    {
        Queue<Pago> pagos = new Queue<Pago>();
        Queue<Cliente> clientes = new Queue<Cliente>();
        List<Ticket> atendidos = new List<Ticket>();
        List<CtaCte> ctaCtes = new List<CtaCte>();

        public void AgregarTicket(Ticket turno)
        {
            if(turno is Cliente c)
            {
                clientes.Enqueue(c);
            }
            else if(turno is Pago p)
            {
                pagos.Enqueue(p);
            }
        }

        public Ticket AtenderTicket(int tipo)
        {
            Ticket atendido = null;
            if(tipo == 1)
            {
                if(clientes.Count >= 0)
                    atendido = clientes.Dequeue();
            }
            else if(tipo == 2)
            {
                if(pagos.Count >= 0)
                    atendido = pagos.Dequeue();
            }
            return atendido;
        }
        public CtaCte VerCuentaCorriente(int nroCC)
        {
            CtaCte busq = new CtaCte(nroCC, null);
            ctaCtes.Sort();
            int idx = ctaCtes.BinarySearch(busq);
            if (idx >= 0)
                return ctaCtes[idx];
            return null; 
        }
        public List<Ticket> VerAtendidos()
        {
            return atendidos;
        }
        public CtaCte AgregarCtaCte(int nroCC, int dni)//Este metodo lo necesito para el importar.
        {
            CtaCte c = VerCuentaCorriente(nroCC);
            if(c == null)
            {
                Cliente titular = new Cliente(dni);
                c = new CtaCte(nroCC, titular);
                ctaCtes.Add(c);
                return c;
            }
            return null;
        }
    }
}
