﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2.Models
{
    public interface IExportable
    {
        void Leer(string linea);
        string Escribir();
    }
}
