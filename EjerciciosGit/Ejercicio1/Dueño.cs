namespace EjerciciosGit.Ejercicio1;

public class Dueño
{
    public string Nombre {get; set;}
    public string Telefono {get; set;}

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
