using System.Collections.Generic;

namespace EscuelaEF.Model
{
    public class AlumnoEstado
    {
        public int AlumnoEstadoId { get; set; }
        public string Descripcion { get; set; }

        public List<Alumno> Alumnos { get; set; }
    }
}
