using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Models
{
    public class Prestamo
    {
        public int PrestamoID { set; get; }
        public DateTime FechaPrestamo { set; get; }
        public DateTime FechaDevolucion { set; get; }
        public Boolean EstadoPrestamo{set; get;}
        public int EjemplarID{set; get;}
        public int LectorID {set; get;}
        //Referencias
        public Ejemplar Ejemplar { set; get; }
        public Lector Lector {set; get;}
        
    }
}