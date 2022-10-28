using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoIntegrador.Models;

namespace ProyectoIntegrador.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Titulo> Titulos{set; get;}
        public DbSet<Ejemplar> Ejemplares{set; get;}
        public DbSet<Area> Areas{set; get;}
        public DbSet<Autor> Autores{set; get;}
        public DbSet<AutorLibro> AutoresLibros{set; get;}
        public DbSet<Ciudad> Ciudades{set; get;}
        public DbSet<Institucion> Instituciones{set; get;}
        public DbSet<Lector> Lector{set; get;}
        public DbSet<Multa> Multas{set; get;}
        public DbSet<Pais> Paises{set; get;}
        public DbSet<Prestamo> Prestamos{set; get;}
        
    }
}
