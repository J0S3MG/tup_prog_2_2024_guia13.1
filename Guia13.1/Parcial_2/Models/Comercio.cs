using System;
using System.Collections.Generic;

namespace Parcial_2.Models
{
    [Serializable]
    public class Comercio
    {
        Queue<Pago> pagos = new Queue<Pago>();
        Queue<Cliente> clientes = new Queue<Cliente>();
        List<Ticket> atendidos = new List<Ticket>();
        List<CtaCte> ctaCtes = new List<CtaCte>();

        public void AgregarTicket(Ticket turno)
        {
            if (turno is Cliente c)
            {
                clientes.Enqueue(c);
            }
            else if (turno is Pago p)
            {
                pagos.Enqueue(p);
            }
        }

        public Ticket AtenderTicket(int tipo)
        {
            Ticket atendido = null;
            if (tipo == 1)
            {
                if (clientes.Count >= 0)
                    atendido = clientes.Dequeue();
            }
            else if (tipo == 2)
            {
                if (pagos.Count >= 0)
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
        public CtaCte AgregarCtaCte(int nroCC, string dni)//Este metodo lo necesito para el importar.
        {
            Cliente titular = new Cliente(dni);
            CtaCte c = new CtaCte(nroCC, titular);
            ctaCtes.Add(c);
            return c;
        }
    }
}
