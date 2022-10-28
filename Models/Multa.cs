using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Models
{
    public class Multa
    {
        public int MultaID { set; get; }
        public double Monto { set; get; }
        public int TiempoRetraso { set; get; }
        public int PrestamoID {set; get;}

        //Relaciones
        public Prestamo Prestamo { set; get; }
       
    }
}