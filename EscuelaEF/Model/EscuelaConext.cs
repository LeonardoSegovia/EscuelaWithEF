using System.Data.Entity.ModelConfiguration.Conventions;

namespace EscuelaEF.Model
{
    using System.Data.Entity;

    public class EscuelaConext : DbContext
    {
        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<AlumnoCurso> AlumnoCurso { get; set; }
        public DbSet<AlumnoEstado> AlumnoEstado { get; set; }
        public DbSet<Curso> Curso { get; set; }

        public EscuelaConext()
            : base("name=EscuelaConext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            #region Alumno

            modelBuilder.Entity<Alumno>().Property(p => p.Nombre).HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Alumno>().Property(p => p.Apellido).HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Alumno>().HasRequired(fk => fk.Estado).WithMany(r => r.Alumnos);

            #endregion

            #region Curso

            modelBuilder.Entity<AlumnoCurso>().HasKey(k => new { k.AlumnoId, k.CursoId });

            modelBuilder.Entity<Curso>().Property(p => p.Nombre).HasMaxLength(50).IsRequired();

            #endregion

            #region Estado

            //modelBuilder.Entity<AlumnoEstado>().HasMany(r => r.Alumnos);

            #endregion

        }

    }
}