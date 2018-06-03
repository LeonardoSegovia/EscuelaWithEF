using System;
using EscuelaEF.Model;

namespace EscuelaEF.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<EscuelaEF.Model.EscuelaConext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EscuelaConext context)
        {

            context.AlumnoEstado.AddOrUpdate(
                new AlumnoEstado
                {
                    AlumnoEstadoId = 0,
                    Descripcion = "Registrado"
                },
                new AlumnoEstado
                {
                    AlumnoEstadoId = 1,
                    Descripcion = "Habilitado - Metricula Inpaga"
                },
                new AlumnoEstado
                {
                    AlumnoEstadoId = 2,
                    Descripcion = "Habilitado"
                });

            context.Alumno.AddOrUpdate(
                new Alumno
                {
                    AlumnoId = 1,
                    Nombre = "Leonardo",
                    Apellido = "Segovia",
                    Actualizado = DateTime.Now,
                    Creado = DateTime.Now
                },
                new Alumno
                {
                    AlumnoId = 2,
                    Nombre = "Yamila",
                    Apellido = "Rosales",
                    Actualizado = DateTime.Now,
                    Creado = DateTime.Now
                }

                );


            context.Curso.AddOrUpdate(
                new Curso
                {
                    CursoId = 1,
                    Nombre ="C# Avanzado",
                    Actualizado = DateTime.Now,
                    Creado = DateTime.Now
                });

            context.Curso.AddOrUpdate(
                new Curso
                {
                    CursoId = 2,
                    Nombre = "ASP .NET MVC",
                    Actualizado = DateTime.Now,
                    Creado = DateTime.Now
                });

        }
    }
}
