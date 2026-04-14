namespace EjerciciosGit.Ejercicio1;

public class Veterinaria
{
    private List<Mascota> ListaMascotas { get; set; }
    public Veterinaria(List<Mascota> mascotas)
    {
        ListaMascotas = mascotas;
    }
    
    public void RegistrarMascota(Mascota mascota)=>ListaMascotas.Add(mascota);
    
    public void MostrarTodas()
    {
        if (ListaMascotas.Count == 0)
        {
            Console.WriteLine("No hay mascotas registradas");
        }
        else
        {
            for(int i=0; i<ListaMascotas.Count; i++)
            {
                ListaMascotas[i].ObtenerInfo();
            }
        }
    }
    
    public void BuscarPorEspecie(string especie)
    {
        bool especieEncontrada=false;
        for(int i=0; i<ListaMascotas.Count; i++)
        {
            if (ListaMascotas[i].Especie.ToLower() == especie.ToLower())
            {
                ListaMascotas[i].ObtenerInfo();
                especieEncontrada=true;
            }
        }
        if (!especieEncontrada)
        {
            Console.WriteLine("No se encontraron mascotas de esa especie.");
        }
    }
}
