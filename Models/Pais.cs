using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoIntegrador.Models
{
    public class Pais
    {
        
        public int PaisID { set; get; }
        [Required]
        [StringLength (40)]
        public string NombrePais  { set; get; } 
        
        //Referencias a otras tablas.
        public ICollection<Ciudad> ciudades { set; get; }
    }
}