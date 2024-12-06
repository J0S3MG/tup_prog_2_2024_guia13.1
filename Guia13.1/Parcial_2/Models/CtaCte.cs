using System;

namespace Parcial_2.Models
{
    public class CtaCte : IExportable, IComparable
    {
        private int nroCtaCte;
        private Cliente titular;
        private double saldo;

        public CtaCte() { }
        public CtaCte(int nro, Cliente titular)
        {
            nroCtaCte = nro;
            this.titular = titular;
        }
        #region Metodos Ver que me retornan (Gettters) el atributo privado. 
        public int VerNro()
        {
            return this.nroCtaCte;
        }
        public Cliente VerTitular()
        {
            return this.titular;
        }
        public double VerSaldo()
        {
            return this.saldo;
        }
        #endregion

        public int CompareTo(object obj)
        {
            CtaCte c = obj as CtaCte;
            if (c != null) return nroCtaCte.CompareTo(c.nroCtaCte);
            return 1;
        }

        public void Leer(string linea)
        {   //(Nro;dni;saldo).
            string[] dat = linea.Split(';');
            int nro = Convert.ToInt32(dat[0]);
            CtaCte c = new CtaCte(nro, null);
            c.saldo = Convert.ToDouble(dat[2]);
        }
        public string Escribir()
        {
            string dat = $"{titular.VerDni()};{nroCtaCte}";
            return dat;
        }
    }
}
