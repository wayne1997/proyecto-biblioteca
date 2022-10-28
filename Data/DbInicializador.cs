using System;
using System.Linq;
using ProyectoIntegrador.Models;

namespace ProyectoIntegrador.Data
{
    public class DbInicializador
    {
        public static void Inicializar(ApplicationDbContext contexto)
        {
            contexto.Database.EnsureCreated();

            if (contexto.Areas.Any())
            {
                return; //No regresa los datos en caso de estar llena.
            }

            var areas = new Area[]
            {
                new Area {NombreArea="Ciencias de la Computación"},
                new Area {NombreArea="Filosofía y Psicología"},
                new Area {NombreArea="Religión y Teología"},
                new Area {NombreArea="Ciencias Sociales"},
                new Area {NombreArea="Lenguas"},
                new Area {NombreArea="Ciencias Básicas"},
                new Area {NombreArea="Tecnología y Ciencias Aplicadas"},
                new Area {NombreArea="Artes y Recreación"},
                new Area {NombreArea="Literatura"},
                new Area {NombreArea="Historia y Geografía"}
            };

            foreach (Area a in areas)
            {
                contexto.Areas.Add(a);
            }
            contexto.SaveChanges();

            
        }
    }
}
