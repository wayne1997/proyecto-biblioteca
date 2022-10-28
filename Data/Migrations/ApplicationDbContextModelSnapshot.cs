﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ProyectoIntegrador.Data;

namespace ProyectoIntegrador.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ProyectoIntegrador.Models.Area", b =>
                {
                    b.Property<int>("AreaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NombreArea")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("AreaID");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("ProyectoIntegrador.Models.Autor", b =>
                {
                    b.Property<int>("AutorID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bibliografia")
                        .IsRequired();

                    b.Property<string>("DirectorioAutor")
                        .IsRequired();

                    b.Property<string>("PrimerApellido")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PrimerNombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("AutorID");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("ProyectoIntegrador.Models.AutorLibro", b =>
                {
                    b.Property<int>("AutorLibroID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AutorID");

                    b.Property<int>("TituloID");

                    b.HasKey("AutorLibroID");

                    b.HasIndex("AutorID");

                    b.HasIndex("TituloID");

                    b.ToTable("AutoresLibros");
                });

            modelBuilder.Entity("ProyectoIntegrador.Models.Ciudad", b =>
                {
                    b.Property<int>("CiudadID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NombreCiudad")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("PaisID");

                    b.HasKey("CiudadID");

                    b.HasIndex("PaisID");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("ProyectoIntegrador.Models.Ejemplar", b =>
                {
                    b.Property<string>("EjemplarID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<bool>("Disponibilidad");

                    b.Property<bool>("EstadoBibliografico");

                    b.Property<int>("TituloID");

                    b.HasKey("EjemplarID");

                    b.HasIndex("TituloID");

                    b.ToTable("Ejemplares");
                });

            modelBuilder.Entity("ProyectoIntegrador.Models.Institucion", b =>
                {
                    b.Property<int>("InstitucionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NombreInstitucion")
                        .IsRequired();

                    b.HasKey("InstitucionID");

                    b.ToTable("Instituciones");
                });

            modelBuilder.Entity("ProyectoIntegrador.Models.Lector", b =>
                {
                    b.Property<string>("LectorID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("DirectorioFoto");

                    b.Property<int>("InstitucionID");

                    b.Property<string>("PrimerApellido")
                        .IsRequired();

                    b.Property<string>("PrimerNombre")
                        .IsRequired();

                    b.Property<string>("Telefono")
                        .HasMaxLength(10);

                    b.HasKey("LectorID");

                    b.HasIndex("InstitucionID");

                    b.ToTable("Lector");
                });

            modelBuilder.Entity("ProyectoIntegrador.Models.Multa", b =>
                {
                    b.Property<int>("MultaID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Monto");

                    b.Property<int>("PrestamoID");

                    b.Property<int>("TiempoRetraso");

                    b.HasKey("MultaID");

                    b.HasIndex("PrestamoID");

                    b.ToTable("Multas");
                });

            modelBuilder.Entity("ProyectoIntegrador.Models.Pais", b =>
                {
                    b.Property<int>("PaisID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NombrePais")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("PaisID");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("ProyectoIntegrador.Models.Prestamo", b =>
                {
                    b.Property<int>("PrestamoID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EjemplarID");

                    b.Property<string>("EjemplarID1");

                    b.Property<bool>("EstadoPrestamo");

                    b.Property<DateTime>("FechaDevolucion");

                    b.Property<DateTime>("FechaPrestamo");

                    b.Property<int>("LectorID");

                    b.Property<string>("LectorID1");

                    b.HasKey("PrestamoID");

                    b.HasIndex("EjemplarID1");

                    b.HasIndex("LectorID1");

                    b.ToTable("Prestamos");
                });

            modelBuilder.Entity("ProyectoIntegrador.Models.Titulo", b =>
                {
                    b.Property<int>("TituloID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AreaID");

                    b.Property<int>("Cantidad");

                    b.Property<int>("CiudadID");

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<string>("DirectorioPortada");

                    b.Property<string>("Edicion");

                    b.Property<DateTime>("Fecha_lanzamiento");

                    b.Property<string>("ISBN")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("PaisID");

                    b.Property<string>("UrlReview");

                    b.HasKey("TituloID");

                    b.HasIndex("AreaID");

                    b.HasIndex("CiudadID");

                    b.HasIndex("PaisID");

                    b.ToTable("Titulos");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProyectoIntegrador.Models.AutorLibro", b =>
                {
                    b.HasOne("ProyectoIntegrador.Models.Autor", "autor")
                        .WithMany()
                        .HasForeignKey("AutorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProyectoIntegrador.Models.Titulo", "titulo")
                        .WithMany()
                        .HasForeignKey("TituloID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProyectoIntegrador.Models.Ciudad", b =>
                {
                    b.HasOne("ProyectoIntegrador.Models.Pais", "pais")
                        .WithMany("ciudades")
                        .HasForeignKey("PaisID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProyectoIntegrador.Models.Ejemplar", b =>
                {
                    b.HasOne("ProyectoIntegrador.Models.Titulo", "titulo")
                        .WithMany("Ejemplares")
                        .HasForeignKey("TituloID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProyectoIntegrador.Models.Lector", b =>
                {
                    b.HasOne("ProyectoIntegrador.Models.Institucion", "Institucion")
                        .WithMany()
                        .HasForeignKey("InstitucionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProyectoIntegrador.Models.Multa", b =>
                {
                    b.HasOne("ProyectoIntegrador.Models.Prestamo", "Prestamo")
                        .WithMany()
                        .HasForeignKey("PrestamoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProyectoIntegrador.Models.Prestamo", b =>
                {
                    b.HasOne("ProyectoIntegrador.Models.Ejemplar", "Ejemplar")
                        .WithMany()
                        .HasForeignKey("EjemplarID1");

                    b.HasOne("ProyectoIntegrador.Models.Lector", "Lector")
                        .WithMany()
                        .HasForeignKey("LectorID1");
                });

            modelBuilder.Entity("ProyectoIntegrador.Models.Titulo", b =>
                {
                    b.HasOne("ProyectoIntegrador.Models.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProyectoIntegrador.Models.Ciudad", "Ciudad")
                        .WithMany()
                        .HasForeignKey("CiudadID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProyectoIntegrador.Models.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("PaisID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}