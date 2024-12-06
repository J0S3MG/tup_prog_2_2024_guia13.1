using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2.Models
{
    public abstract class Ticket: IExportable
    {
        protected int nroOrden;
        private DateTime fechaHora;

        #region Metodos Ver que me retornan (Gettters) el atributo privado. 
        public int VerNro()
        {
            return nroOrden;
        }
        public DateTime VerFH()
        {
            return fechaHora;
        }
        #endregion

        public virtual void Leer(string linea)
        {
            
        }
        public virtual string Escribir()
        {
            string dat = $"{nroOrden}";
            return dat;
        }
    }
}
