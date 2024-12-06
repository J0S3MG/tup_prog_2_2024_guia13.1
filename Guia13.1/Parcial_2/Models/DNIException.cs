using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2.Models
{
    public class DNIException: ApplicationException
    {
        public DNIException() : base("Error al ingresar el DNI") { }
        public DNIException(string message) : base(message) { }
        public DNIException(string msj, Exception e) : base(msj, e) { }
    }
}
