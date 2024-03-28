namespace clases.Models;

// Clase heroe
class SuperHeroe {
    // Encapsulamiento de nombre
    private string _Nombre;
    
    public int Id;

    public string Nombre
    {
        get { return _Nombre; }
        set { _Nombre = value.Trim(); }
    }
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