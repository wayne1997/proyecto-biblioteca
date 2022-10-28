using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoIntegrador.Models
{
    public class Lector
    {
        [Required, StringLength(10)]
        [Display(Name ="Código de afiliado")]
        public string LectorID { set; get; }
        [Required]
        [Display (Name ="Primer nombre")]
        public string PrimerNombre { set; get; }
        [Required]
        [Display (Name ="Primer apellido")]
        public string PrimerApellido { set; get; } 
        [StringLength (10, MinimumLength =9)]
        public string Telefono { set; get; } 
        [Required, StringLength (50)]
        [EmailAddress]
        public string Correo { set; get; }
        public string DirectorioFoto { set; get; }
        public int InstitucionID{set; get;}

        //Referencias
        public Institucion Institucion { set; get; }
    }
}