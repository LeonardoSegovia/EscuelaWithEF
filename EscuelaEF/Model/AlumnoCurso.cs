using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscuelaEF.Model
{
    public class AlumnoCurso
    {
        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }

        public int CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
