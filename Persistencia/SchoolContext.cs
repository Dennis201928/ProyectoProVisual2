using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelo.Escuela;
using Persistencia;

namespace Virtual
{
    public class SchoolContext : DbContext
    {

        public DbSet<carro> carros { get; set; }
        public DbSet<cliente> Clientes { get; set; }
        public DbSet<genero> generos { get; set; }
        public DbSet<iva> ivas { get; set; }
        public DbSet<marca> marcas { get; set; }
        public DbSet<modelo> modelos { get; set; }
        public DbSet<tipopago> tipopagos { get; set; }
        public DbSet<venta> ventas { get; set; }
        //public DbSet<Profesor> profesors { get; set; }

        //public DbSet<Area> areas { get; set; }

        // Constructor vacio
        public SchoolContext() : base()
        {

        }

        // Constructor para pasar la conexión al padre
        public SchoolContext(DbContextOptions<SchoolContext> opciones)
            : base(opciones)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                switch (EscuelaConfig.PersistenciaDestino)
                {
                    case "SQLServerEscuela":
                        optionsBuilder.UseSqlServer(EscuelaConfig.connectionString);
                        break;
                    case "PostgresEscuela":
                        optionsBuilder.UseNpgsql(EscuelaConfig.connectionString);
                        break;
                    case "memoriaEscuela":
                        optionsBuilder.UseInMemoryDatabase(EscuelaConfig.connectionString);
                        break;
                }
            }

        }
        //////--------------------------------------------------------------------/////
        ///-----------------RELACIONES DE CLASES---------------------------////
        ///----------------Tablas ya creadas---------------------------------////
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<carro>()
               .HasOne(mat => mat.marca)
               .WithMany(car => car.carros)
               .HasForeignKey(mat => mat.marcaId);

            modelBuilder.Entity<carro>()
              .HasOne(mat => mat.modelo)
              .WithMany(est => est.carros)
              .HasForeignKey(mat => mat.modeloId);

         
            // Relación uno a muchos; carro marca
            modelBuilder.Entity<venta>()
                .HasOne(mat => mat.carro)
                .WithMany(ve => ve.ventas)
                .HasForeignKey(mat => mat.carroId);


            modelBuilder.Entity<cliente>()
              .HasOne(mat => mat.genero)
              .WithMany(cli => cli.clientes)
              .HasForeignKey(mat => mat.generoId);

            modelBuilder.Entity<venta>()
              .HasOne(mat => mat.cliente)
              .WithMany(ven => ven.ventas)
              .HasForeignKey(mat => mat.clienteId);


            modelBuilder.Entity<venta>()
           .HasOne(mat => mat.carro)
           .WithMany(vent => vent.ventas)
           .HasForeignKey(mat => mat.carroId);

            modelBuilder.Entity<venta>()
           .HasOne(mat => mat.tipopago)
           .WithMany(venta => venta.ventas)
           .HasForeignKey(mat => mat.tipopagoId);

            modelBuilder.Entity<venta>()
          .HasOne(mar => mar.iva)
          .WithMany(ventas => ventas.ventas)
          .HasForeignKey(mat => mat.ivaId);

        }

    }
}














//        public DbSet<Estudiante> estudiantes { get; set; }
//        public DbSet<Curso> cursos { get; set; }
//        public DbSet<Materia> materias { get; set; }
//        public DbSet<Matricula> matriculas { get; set; }
//        public DbSet<Matricula_Det> matriculas_Det { get; set; }
//        public DbSet<Calificacion> calificaciones { get; set; }
//        public DbSet<Carrera> carreras { get; set; }
//        public DbSet<Malla> mallas { get; set; }
//        public DbSet<Periodo> periodos { get; set; }
//        public DbSet<Prerequisito> prerequisitos { get; set; }
//        public DbSet<Configuracion> configuracions { get; set; }

//        public DbSet<Jornada> Jornadas { get; set; }
//        //public DbSet<Profesor> profesors { get; set; }

//        //public DbSet<Area> areas { get; set; }

//        // Constructor vacio
//        public SchoolContext() : base()
//        {

//        }

//        // Constructor para pasar la conexión al padre
//        public SchoolContext(DbContextOptions<SchoolContext> opciones)
//            : base(opciones)
//        {

//        }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
//            if (!optionsBuilder.IsConfigured)
//            {
//                switch (EscuelaConfig.PersistenciaDestino) {
//                    case "SQLServerEscuela":
//                        optionsBuilder.UseSqlServer(EscuelaConfig.connectionString);
//                        break;
//                    case "PostgresEscuela":
//                        optionsBuilder.UseNpgsql(EscuelaConfig.connectionString);
//                        break;
//                    case "memoriaEscuela":
//                        optionsBuilder.UseInMemoryDatabase(EscuelaConfig.connectionString);
//                        break;
//                }
//            }

//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            // Relación uno a muchos; un Estudiante tiene muchas Matrículas 
//            modelBuilder.Entity<Matricula>()
//                .HasOne(mat => mat.Estudiante)
//                .WithMany(est => est.Matriculas)
//                .HasForeignKey(mat => mat.EstudianteId);

//            // Relación uno a muchos; una Matrícula a una carrera
//            modelBuilder.Entity<Matricula>()
//                .HasOne(mat => mat.Carrera)
//                .WithMany(car => car.Matriculas)
//                .HasForeignKey(mat => mat.CarreraId);

//            // Relación uno a muchos; en un período se registran varias matrículas
//            modelBuilder.Entity<Matricula>()
//                .HasOne(mat => mat.Periodo)
//                .WithMany(per => per.Matriculas)
//                .HasForeignKey(mat => mat.PeriodoId);

//            // Relación de uno a muchos: cabecera detalle de la matrícula
//            modelBuilder.Entity<Matricula_Det>()
//                .HasOne(det => det.Matricula)
//                .WithMany(mat => mat.Matricula_Dets)
//                .OnDelete(DeleteBehavior.NoAction)
//                .HasForeignKey(det => det.MatriculaId);

//            // Relación de uno a muchos: Cursos con detalles de la matrícula
//            modelBuilder.Entity<Matricula_Det>()
//                .HasOne(det => det.Curso)
//                .WithMany(cur => cur.Matricula_Dets)
//                .HasForeignKey(det => det.CursoId);
//            //Relacion con cursos y jornada
//            modelBuilder.Entity<Curso>()
//                .HasOne(det => det.Jornada)
//                .WithMany(cur => cur.Curso)
//                .HasForeignKey(det => det.JornadaId);

//            // Relación uno a uno; una Matrícula_Det tiene una Calificación
//            modelBuilder.Entity<Matricula_Det>()
//                .HasOne(det => det.Calificacion)
//                .WithOne(calif => calif.Matricula_Det)
//                .HasForeignKey<Calificacion>(calif => calif.Matricula_DetId);

//            // Relación uno a muchos; una Materia se dicta en muchos Cursos
//            modelBuilder.Entity<Curso>()
//                .HasOne(cur => cur.Materia)
//                .WithMany(mat => mat.Cursos)
//                .HasForeignKey(cur => cur.MateriaId);

//            modelBuilder.Entity<Curso>()
//                .HasOne(cur => cur.Periodo)
//                .WithMany(per => per.Cursos)
//                .HasForeignKey(cur => cur.PeriodoId);

//            // Relación uno a uno de Malla con Materia
//            modelBuilder.Entity<Malla>()
//                .HasOne(malla => malla.Materia)
//                .WithOne(mat => mat.Malla)
//                .HasForeignKey<Malla>(malla => malla.MateriaId);

//            // Relación Malla - Prerequisitos - Matrias
//            modelBuilder.Entity<Prerequisito>()
//                .HasKey(pre => new { pre.MallaId, pre.MateriaId });

//            modelBuilder.Entity<Prerequisito>()
//                .HasOne(pre => pre.Malla)
//                .WithMany(malla => malla.PreRequisitos)
//                .OnDelete(DeleteBehavior.NoAction)
//                .HasForeignKey(pre => pre.MallaId);

//            modelBuilder.Entity<Prerequisito>()
//                .HasOne(pre => pre.Materia)
//                .WithMany(mat => mat.Prerequisitos)
//                .OnDelete(DeleteBehavior.NoAction)
//                .HasForeignKey(pre => pre.MateriaId);

//        }

//    }
//}
