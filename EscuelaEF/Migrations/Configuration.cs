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

            context.Alumno.AddOrUpdate(
                new Alumno
                {
                    Nombre = "Leonardo",
                    Apellido = "Segovia",
                    Actualizado = DateTime.Now,
                    Creado = DateTime.Now
                },
                new Alumno
                {
                    Nombre = "Yamila",
                    Apellido = "Rosales",
                    Actualizado = DateTime.Now,
                    Creado = DateTime.Now
                }

                );

        }
    }
}
