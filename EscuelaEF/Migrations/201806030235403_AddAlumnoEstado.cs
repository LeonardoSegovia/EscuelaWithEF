namespace EscuelaEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddAlumnoEstado : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumno",
                c => new
                {
                    AlumnoId = c.Int(nullable: false, identity: true),
                    Nombre = c.String(nullable: false, maxLength: 50),
                    Apellido = c.String(nullable: false, maxLength: 50),
                    Creado = c.DateTime(nullable: false),
                    Actualizado = c.DateTime(nullable: false),
                    AlumnoEstadoId = c.Int(nullable: false, defaultValue: 0),
                })
                .PrimaryKey(t => t.AlumnoId)
                .ForeignKey("dbo.AlumnoEstado", t => t.AlumnoEstadoId, cascadeDelete: true)
                .Index(t => t.AlumnoEstadoId);

            CreateTable(
                "dbo.AlumnoCurso",
                c => new
                {
                    AlumnoId = c.Int(nullable: false),
                    CursoId = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.AlumnoId, t.CursoId })
                .ForeignKey("dbo.Alumno", t => t.AlumnoId, cascadeDelete: true)
                .ForeignKey("dbo.Curso", t => t.CursoId, cascadeDelete: true)
                .Index(t => t.AlumnoId)
                .Index(t => t.CursoId);

            CreateTable(
                "dbo.Curso",
                c => new
                {
                    CursoId = c.Int(nullable: false, identity: true),
                    Nombre = c.String(nullable: false, maxLength: 50),
                    Creado = c.DateTime(nullable: false),
                    Actualizado = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.CursoId);

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

            CreateTable(
                "dbo.AlumnoEstado",
                c => new
                {
                    AlumnoEstadoId = c.Int(nullable: false, identity: true),
                    Descripcion = c.String(),
                })
                .PrimaryKey(t => t.AlumnoEstadoId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Alumno", "AlumnoEstadoId", "dbo.AlumnoEstado");
            DropForeignKey("dbo.AlumnoDireccion", "AlumnoId", "dbo.Alumno");
            DropForeignKey("dbo.AlumnoCurso", "CursoId", "dbo.Curso");
            DropForeignKey("dbo.AlumnoCurso", "AlumnoId", "dbo.Alumno");
            DropIndex("dbo.AlumnoDireccion", new[] { "AlumnoId" });
            DropIndex("dbo.AlumnoCurso", new[] { "CursoId" });
            DropIndex("dbo.AlumnoCurso", new[] { "AlumnoId" });
            DropIndex("dbo.Alumno", new[] { "AlumnoEstadoId" });
            DropTable("dbo.AlumnoEstado");
            DropTable("dbo.AlumnoDireccion");
            DropTable("dbo.Curso");
            DropTable("dbo.AlumnoCurso");
            DropTable("dbo.Alumno");
        }
    }
}
