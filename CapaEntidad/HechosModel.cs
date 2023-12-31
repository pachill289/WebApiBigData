﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class HechosModel
    {
        public int idHecho { get; set; }
        public int Hora { get; set; } // 0-6 6-8 8-12 12-15 3-7 7-12 (se tienen 6 opciones)
        public string colorFondo { get; set; } // generar colores 7 del arcoiris
        public string colorTexto { get; set; } // generar colores 7 del arcoiris
        public string Mensaje { get; set; } //mensajes positivos y negativos
        //public bool Like { get; set; } // es parte de los hechos 0 o 1
        public string Profesion { get; set; }
        public string Resultado { get; set; }
        public char Genero { get; set; }
    }
}
