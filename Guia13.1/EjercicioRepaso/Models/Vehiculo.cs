using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.Models
{
    public class Vehiculo: IComparable//Implemento la interfaz icomparable para la busqueda
    {
        private Cliente dueño;
        private string pat;

        public Vehiculo(Cliente dueño, string pat)
        {
            this.dueño=dueño;
            this.pat=pat;
        }
        #region Hago metodos que me retornen los valores de los atributos
        public Cliente VerDueño()
        {
            return dueño;
        }
        public string VerPatente()
        {
            return pat;
        }
        #endregion

        public override string ToString()//Hago un ToString que el ejercicio no pide pero es necesario para mostrarlo en el listbox.
        {
            return $"{pat}";
        }
        public int CompareTo(object obj)
        {
            Vehiculo v = obj as Vehiculo;
            if (v != null)
                return pat.CompareTo(v.VerPatente());//Como el atributo pat es privado para acceder a su valor utilizo el metodo Ver.
            return 1;
        }
    }
}
