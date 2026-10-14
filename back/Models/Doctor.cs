namespace back.Models;

public class Doctor : Usuario
{
    public string Especialidad { get; set; } = string.Empty;


    // Horarios en los que atiende el doctor
    //public List<HorarioAtencion> Horarios { get; set; } = new(); //A charlar todavia

    // Turnos asignados a este doctor
    public List<Turno> Turnos { get; set; } = new();
}