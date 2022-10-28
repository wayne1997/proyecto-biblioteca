using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ProyectoIntegrador.Models
{
    public class Ciudad
    {
        public int CiudadID { set; get; }
        [Required]
        [StringLength (40)]
        public string NombreCiudad { set; get; }

        //Referencias a otras tablas
        [Required]
        public int PaisID {set; get;}
        public Pais pais { set; get; }
    }
}