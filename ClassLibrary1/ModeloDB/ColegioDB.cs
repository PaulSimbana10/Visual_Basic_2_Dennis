using Microsoft.EntityFrameworkCore;
using Modelos.Entidades;

namespace ModeloDB
{
    public class ColegioDB : DbContext
    {
        public ColegioDB(DbContextOptions<ColegioDB> options)
            : base(options)
        {

        }

        // Declaración de las entidades del modelo
        public DbSet<Estudiante> estudiantes { get; set; }
        
        public DbSet<Estados> estados { get; set; }
        public DbSet<Pagos> pagos { get; set; }
        public DbSet<PagosPorPeriodo> pagosporperiodo { get; set; }
        public DbSet<Penalizacion> penalizaciones { get; set; }
        public DbSet<TiposPago> tipospagos { get; set; }
        public DbSet<Periodo> periodos { get; set; }
        public DbSet<Configuracion> configuracion { get; set; }

        //Configuración de la conección
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlServer("Server=victor-pc\\sql2012; Initial Catalog=SGA; trusted_connection=true;");
        //}

        // Configurar el modelo de clases
        protected override void OnModelCreating(ModelBuilder model)
        {
            // Configuración de Estados
            // - Pago y estado
            model.Entity<Pagos>()
                .HasOne(pagos => pagos.Estados)
                .WithMany(estados => estados.pagos)
                .HasForeignKey(pagos => pagos.EstadoID);
            // -Pago y Periodo
            model.Entity<Pagos>()
                .HasOne(pagos => pagos.Periodo)
                .WithMany(periodo => periodo.Pagos)
                .HasForeignKey(pagos => pagos.PeriodoID);
            // - Pago y tipos pago
            model.Entity<Pagos>()
                .HasOne(pagos => pagos.TiposPago)
                .WithMany(tipospagos => tipospagos.Pagos)
                .HasForeignKey(pagos => pagos.TiposPagoID);

            // Configuración de Matriculas_Det
            // Matricula_Det con Matricula
            model.Entity<Pagos>()
                .HasOne(pagos => pagos.Estudiante)
                .WithMany(estudiantes => estudiantes.Pagos)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(pagos => pagos.EstudianteID);
          




        }
    }
}
