using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoIntegrador.Models
{
    public class Area
    {
         public int AreaID { set; get; }
        [Required, StringLength(50)]
        public string NombreArea { set; get; }
    }
}