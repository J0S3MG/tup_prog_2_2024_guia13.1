using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.Models
{
    public abstract class Ticket
    {
        protected int nroO;
        private DateTime fh;

        public Ticket()
        {
            fh = DateTime.Now;
        }
        #region Hago metodos que me retornen los valores de los atributos
        public int VerNro()
        {
            return nroO;
        }
        public DateTime VerFH()
        {
            return fh;
        }
        #endregion
        public override string ToString()//Hago un ToString que el ejercicio no pide pero es necesario para mostrarlo en el listbox.
        {
            return $"{VerNro()};{VerFH():d/M/yyyy}";
        }
    }
}
