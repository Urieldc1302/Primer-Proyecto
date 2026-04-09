namespace EjerciciosGit.Ejercicio1;

public class Dueño
{
    public required string Nombre {get; set;}
    public required string Telefono {get; set;}

    public Dueño(string nombre, string telefono)
    {
        Nombre = nombre;
        Telefono = telefono;
    }

    public void ObtenerInfo()
    {
        Console.WriteLine("Nombre: ", Nombre, "| Telefono: ", Telefono);
    }
}
