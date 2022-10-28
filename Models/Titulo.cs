using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoIntegrador.Models
{
    public class Titulo
    {
        public int TituloID { set; get; }
        [Required]
        public string Nombre { set; get; }
        [Required]
        public string ISBN { set; get; }
        public string Edicion { set; get; }
        public DateTime Fecha_lanzamiento { set; get; }
        [Required]
        public int Cantidad { set; get; }
        [Required]
        public string Descripcion { set; get; }
        public string DirectorioPortada { set; get; }
        public string UrlReview { set; get; }
        public int PaisID {set; get;}
        public int CiudadID {set; get;}
        public int AreaID {set; get;}
        
        public ICollection<Ejemplar> Ejemplares{set; get;}     
        public Pais Pais {set; get;}
        public Ciudad Ciudad {set; get;}
        public Area Area {set; get;}    
    }
}