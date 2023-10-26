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
        [Required]
        public int Hora { get; set; } // 0-6 6-8 8-12 12-15 3-7 7-12 (se tienen 6 opciones)
        [Required]
        [StringLength(30)]
        public string colorFondo { get; set; } // generar colores 7 del arcoiris
        [Required]
        [StringLength(30)]
        public string colorTexto { get; set; } // generar colores 7 del arcoiris
        [Required]
        [StringLength(500)]
        public string Mensaje { get; set; } //mensajes positivos y negativos
        /*[Required]
        public bool Like { get; set; } // es parte de los hechos 0 o 1*/
        [Required]
        public char Genero { get; set; }
        [Required]
        [StringLength(200)]
        public string Profesion { get; set; }
        [Required]
        [StringLength(200)]
        public string Resultado { get; set; }
    }
}
