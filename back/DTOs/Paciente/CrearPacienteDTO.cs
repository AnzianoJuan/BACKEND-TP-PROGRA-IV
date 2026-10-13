namespace back.DTOs.Paciente
{
    public class CrearPacienteDTO
    {
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string Contraseña { get; set; } = string.Empty;

        public string Rol { get; set; } = "paciente"; // "paciente" | "admin o tambien a ver el tema del doctor..."
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public List<Turno> TurnosComoPaciente { get; set; } = new();
    }
}
