using Microsoft.EntityFrameworkCore;
using Modelo.Colegio;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModeloBD
{
    
    public class ColegioBD : DbContext
    {
        //configuracion de las entidades
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Ciclo> Ciclos { get; set; }
        public DbSet<Configuracion> Configuraciones { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Grado> Grados { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<PagoDet> PagosDets { get; set; }
        public DbSet<Periodo> Valor { get; set; }


        //Configuracion de la coneccion

        //Cadena de coneccion 
        /*protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string conn = "Data source=localhost; Initial Catalog=SchoolDB; Integrated Security=true;";
            options.UseSqlServer("Server=DESKTOP-0R6KRQF\\sqlserver2012; Initial Catalog=PPC; trusted_connection=true;");
            //string connPostGreSQL = " Host = localhost; Database = colegioBDD; Username = postgres; Password = 1234";
            //dbContextOptions.UseNpgsql(connPostGreSQL);
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<Pago>().HasOne(Pago => Pago.Alumno).WithMany(Periodo=>Periodo.alumnoId).
              

        }
        }


    }


