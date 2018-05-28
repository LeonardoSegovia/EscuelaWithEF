namespace EscuelaEF.Model
{
    public class AlumnoDireccion
    {
        public int AlumnoDireccionId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }

    }
}
