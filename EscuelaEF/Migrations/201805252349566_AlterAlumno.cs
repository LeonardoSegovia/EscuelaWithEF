namespace EscuelaEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterAlumno : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alumno", "Creado", c => c.DateTime(nullable: false));
            AddColumn("dbo.Alumno", "Actualizado", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Alumno", "Actualizado");
            DropColumn("dbo.Alumno", "Creado");
        }
    }
}
