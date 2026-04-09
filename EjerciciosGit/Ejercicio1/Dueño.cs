namespace EjerciciosGit.Ejercicio1;

public class Dueño
{
    public required string Nombre {get; set;}
    public required string Telefono {get; set;}

    public void ObtenerInfo()
    {
        Console.WriteLine("Nombre: ", Nombre, "| Teléfono: ", Telefono);
    }
}
