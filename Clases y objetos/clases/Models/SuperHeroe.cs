namespace clases.Models;

// Clase heroe
class SuperHeroe {
    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes;
    public bool PuedeVolar;

    // Constructor
    public SuperHeroe(){
        Id = 1;
        SuperPoderes = new List<SuperPoder>();
        PuedeVolar = false;
    }

    // Metodo dentro de una clase
    public void UsarSuperPoder(){
        foreach (var item in SuperPoderes)
            Console.WriteLine($"{Nombre} esta usando el super poder {item.Nombre}");
    }

}