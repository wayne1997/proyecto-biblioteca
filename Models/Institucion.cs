using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoIntegrador.Models
{
    public class Institucion
    {
        public int InstitucionID { set; get; }
        [Required]
        public string NombreInstitucion { set; get; }
    }
}