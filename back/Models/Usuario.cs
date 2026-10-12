namespace back.Models;

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public string Contraseña { get; set; } = string.Empty;

    public string Rol { get; set; } = "paciente"; // "paciente" | "admin o tambien a ver el tema del doctor..."
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

    // esta es una relacion donde permitira al usuario luego tener una lista de turnos
    public List<Turno> TurnosComoPaciente { get; set; } = new();
    public List<Turno> TurnosComoDoctor { get; set; } = new();
}