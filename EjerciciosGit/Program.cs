using EjerciciosGit.Ejercicio1;

EjercicioVeterinaria();
static void EjercicioVeterinaria()
{
    Dueño dueño1 = new Dueño("Faustino", "234234");
    Dueño dueño2 = new Dueño("Marcos", "234234");
    Dueño dueño3 = new Dueño("Uriel", "3251235");
    
    
    Mascota mascota1 = new Mascota("Sofía", "gato", 2, dueño3);
    Mascota mascota2 = new Mascota("Uma", "perro", 8, dueño2);
    Mascota mascota3 = new Mascota("Galo", "perro", 3, dueño1);
    Mascota mascota4 = new Mascota("Tom", "perro", 9, dueño2);

    Veterinaria veterinaria = new Veterinaria([mascota1,mascota2,mascota3,mascota4]);

    veterinaria.MostrarTodas();
    veterinaria.BuscarPorEspecie("perro");
}