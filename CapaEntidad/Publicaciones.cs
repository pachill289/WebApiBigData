using System;
using System.ComponentModel.DataAnnotations;

namespace CapaEntidad {
    public class Publicaciones {
        public int idPublicacion { get; set; }
        public int Hora { get; set; } // 0-6 6-8 8-12 12-15 3-7 7-12 (se tienen 6 opciones)
        public uint colorFondo { get; set; } // generar colores 7 del arcoiris
        public uint colorTexto { get; set; } // generar colores 7 del arcoiris
        public string Mensaje { get; set; } //mensajes positivos y negativos
        public bool Like { get; set; } // es parte de los hechos 0 o 1
        public string Ip { get; set; }
    }
}
