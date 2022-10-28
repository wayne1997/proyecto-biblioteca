using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoIntegrador.Models
{
    public class Autor
    {
        public int AutorID { set; get; }
        [Required,StringLength (50)]
        public string PrimerNombre { set; get; }
        [Required, StringLength (50)]
        public string PrimerApellido { set; get; }
        [Required]
        public string DirectorioAutor { set; get; }
        [Required]
        public string Bibliografia { set; get; }

    }
}