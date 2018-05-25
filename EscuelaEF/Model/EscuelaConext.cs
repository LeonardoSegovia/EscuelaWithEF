using System.Data.Entity.ModelConfiguration.Conventions;

namespace EscuelaEF.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EscuelaConext : DbContext
    {
        // Your context has been configured to use a 'EscuelaConext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EscuelaEF.Model.EscuelaConext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EscuelaConext' 
        // connection string in the application configuration file.
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