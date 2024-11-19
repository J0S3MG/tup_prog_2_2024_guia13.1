using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.Models
{
    public class DNIException: ApplicationException//Creo mi excepcion personalizada
    {
        public DNIException() { }
        public DNIException(string message) : base(message) { }
        public DNIException(string msj,Exception e): base(msj,e){ }
    }
}
