using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.Models
{
    public class Cliente: Ticket//Hereda de ticket
    {
        #region Atributos
        private static int nro;
        private long dni;
        private int tipo;
        #endregion
        public Cliente(string dni, int tipo)
        {
            nroO = nro++;
            this.tipo = tipo;
            #region Hago el Chequeo para lanzar la Excepcion
            bool hayNumeros = dni.Length != 0;//Inicializo un boleano en true si dni es distinto de cero sino en false.
            for (int n = 0; n < dni.Length && hayNumeros==true; n++)//Creo un for que va hasta el tamaño del string si hayNumeros es true.
            {
                hayNumeros &= char.IsNumber(dni[n]) == true;//hayNumeros es true siempre y cuando IsNumber devuelva true.
            }
            if (hayNumeros==false)//Si hayNumeros es false lanza la excepcion
                throw new DNIException("Hay caracteres no numéricos");
            //Una vez chequeada la cadena se convierte a entero.
            this.dni = Convert.ToInt64(dni);
            //Si el numero entero es mayor a 5000000 salta una excepcion.
            if (this.dni < 5000000)
                throw new DNIException("El DNI debe ser mayor a 5000000");
            #endregion
        }
        public override string ToString()//Hago un ToString que el ejercicio no pide pero es necesario para mostrarlo en el listbox.
        {
            return $"CLIENTE;{base.ToString()};{dni}";
        }
    }
}
