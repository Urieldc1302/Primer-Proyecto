namespace EjerciciosGit.Ejercicio1;

public class Mascota
{
    public required string Nombre { get; set; }
    public required string Especie { get; set; }
    public int Edad { get; set; }
    public required Dueño Dueño {get; set;}

    public Mascota(string nombre, string especie, int edad, Dueño dueño)
    {
        Nombre = nombre;
        Especie = especie;
        Edad = edad;
        Dueño = dueño;
    }

    public void ObtenerInfo()
    {
        Console.WriteLine("Nombre:", Nombre, "| Especie:", Especie, "| Edad:", Edad, "| Dueño:", Dueño);
    }
}
