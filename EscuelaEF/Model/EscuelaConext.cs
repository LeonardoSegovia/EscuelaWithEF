using System.Data.Entity.ModelConfiguration.Conventions;

namespace EscuelaEF.Model
{
    using System.Data.Entity;

    public class EscuelaConext : DbContext
    {
        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<AlumnoCurso> AlumnoCurso { get; set; }
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

            #endregion

            #region Curso

            modelBuilder.Entity<Curso>().Property(p => p.Nombre).HasMaxLength(50).IsRequired();

            #endregion


            #region AlumnoCurso

            modelBuilder.Entity<AlumnoCurso>().HasKey(k => new {k.AlumnoId, k.CursoId});

            #endregion

        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}