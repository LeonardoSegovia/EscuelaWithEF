namespace EscuelaEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDireccion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AlumnoDireccion",
                c => new
                    {
                        AlumnoDireccionId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        AlumnoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AlumnoDireccionId)
                .ForeignKey("dbo.Alumno", t => t.AlumnoId, cascadeDelete: true)
                .Index(t => t.AlumnoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AlumnoDireccion", "AlumnoId", "dbo.Alumno");
            DropIndex("dbo.AlumnoDireccion", new[] { "AlumnoId" });
            DropTable("dbo.AlumnoDireccion");
        }
    }
}
