using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Parcial_2.Models
{
    public class Cliente: Ticket
    {
        static int nroInicio;
        int dni;
        public Cliente() { }
        public Cliente(int dni) 
        {
            if (dni <= 3000000 || dni >= 45000000)
            {
                throw new DNIException();
            }
            this.dni = dni;
        }
        public Cliente(string dni)
        {
            #region Hago el manejo de la excepcion.
            string patron = @"^\d{8}$";
            if (Regex.IsMatch(dni, patron) == false)
            {
                throw new DNIException();
            }
            else
            {
                int d = Convert.ToInt32(dni);
                if (d <= 3000000 || d >= 45000000)
                {
                    throw new DNIException();
                }
                this.dni = d;
            }
            #endregion
            nroOrden = nroInicio++;
        }
        public int VerDni()
        {
            return this.dni;
        }
        public override void Leer(string linea)
        {
            //(Nro;dni;saldo).
            string[] dat = linea.Split(';');
            int dni = Convert.ToInt32(dat[1]);
        }
        public override string Escribir()
        {
            string dat = $"Cliente;{base.Escribir()};{dni}";
            return dat;
        }
    }
}
