using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoIntegrador.Models
{
    public class Ejemplar
    {
        [Required]
        [StringLength (10, MinimumLength =7)]
        public string EjemplarID { set; get; }
        public Boolean EstadoBibliografico { set; get; }
        public Boolean Disponibilidad { set; get; }
        

        //Estas son las relaciones entre entidades.
      
        public int TituloID { set; get; } 
        public Titulo titulo{set; get;}
    }
}