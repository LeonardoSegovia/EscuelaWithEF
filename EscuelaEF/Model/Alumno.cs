
using System;
using System.Collections.Generic;

namespace EscuelaEF.Model
{
    public class Alumno
    {
        public int AlumnoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Creado { get; set; }
        public DateTime Actualizado { get; set; }

        public List<AlumnoCurso> Cursos { get; set; }
        public List<AlumnoDireccion> Direcciones { get; set; }
    }
}
