using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.Models
{
    public  class Denuncia: Ticket//Hereda de ticket
    {
        private Vehiculo dominio;
        private static int nro; 

        public Denuncia(Vehiculo dominio)
        {
            this.dominio=dominio;
            nroO = nro++;
        }
        public override string ToString()//Hago un ToString que el ejercicio no pide pero es necesario para mostrarlo en el listbox.
        {
            return $"DENUNCIA;{base.ToString()};{dominio.ToString()}";
        }
    }
}
