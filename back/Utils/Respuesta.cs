namespace back.Utils;

public class Respuesta
{
    public string Mensaje { get; set; } = string.Empty;
    public object? Datos { get; set; }

    public Respuesta(string? msg)
    {
        Mensaje = msg ?? string.Empty;
    }
}