using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    [Table("Hechos")]
    public class Hechos
    {
        [Key]
        public int idHecho { get; set; }
        public int Hora { get; set; } // 0-6 6-8 8-12 12-15 3-7 7-12 (se tienen 6 opciones)
        public uint colorFondo { get; set; } // generar colores 7 del arcoiris
        public uint colorTexto { get; set; } // generar colores 7 del arcoiris
        public string Mensaje { get; set; } //mensajes positivos y negativos
        public bool Like { get; set; } // es parte de los hechos 0 o 1
        public string Resultado { get; set; }
    }
}
