using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoIntegrador.Models
{
    public class AutorLibro
    {
        public int AutorLibroID{set; get;}
        public int AutorID {set; get;}
        public int TituloID {set; get;}
        public Titulo titulo {set; get;}
        public Autor autor {set; get;}
    }
}