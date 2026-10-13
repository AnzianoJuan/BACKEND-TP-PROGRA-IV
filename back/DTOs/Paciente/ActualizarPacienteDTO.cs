namespace back.DTOs.Paciente
{
    public class ActualizarPacienteDTO
    {
        public string? Nombre { get; set; } 
        public string? Apellido { get; set; }
        public string? Email { get; set; } 

        public string? Contraseña { get; set; } 
        public List<Turno>? TurnosComoPaciente { get; set; } = new();
    }
}
