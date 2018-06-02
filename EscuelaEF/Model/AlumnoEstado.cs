namespace EscuelaEF.Model
{
    public class AlumnoEstado
    {
        public int AlumnoEstadoId { get; set; }
        public string Descripcion { get; set; }

        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }

    }
}
