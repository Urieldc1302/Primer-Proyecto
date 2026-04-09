namespace EjerciciosGit.Ejercicio1;

public class Mascota
{
    public string Nombre { get; set; }
    public string Especie { get; set; }
    public int Edad { get; set; }
    public Dueño Dueño {get; set;}

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
