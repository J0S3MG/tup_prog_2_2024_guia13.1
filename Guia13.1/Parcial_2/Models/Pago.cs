using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2.Models
{
    public class Pago: Ticket
    {
        static int nroInicio;
        CtaCte ficha;
        public Pago() { }
        public Pago(CtaCte ficha)
        {
            this.ficha = ficha;
            nroOrden = nroInicio++;
        }

        public override string Escribir()
        {
            string dat = $"Pago;{base.Escribir()};{ficha.Escribir()}";
            return dat;
        }
    }
}
