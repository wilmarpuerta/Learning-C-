namespace clases.Models;

// Clase heroe
public class SuperHeroe : Heroe
{
    // Encapsulamiento de nombre
    private string _Nombre;
    
    public int Id;

    public string Nombre
    {
        get { return _Nombre; }
        set { _Nombre = value.Trim(); }
    }
    public string IdentidadSecreta;

    public string NombreIdentidadSecreta
    {
        get { return $"{Nombre} ({IdentidadSecreta})"; }
    }
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
            Console.WriteLine($"{NombreIdentidadSecreta} esta usando el super poder {item.Nombre}");
    }
    
    // Abtraccion
    public override string SalvarElMundo()
    {
        return $"{NombreIdentidadSecreta} ha salvado el mundo";
    }
    
    // Polimorfismo
    public override string SalvarLaTierra()
    {
        return $"{NombreIdentidadSecreta} ha salvado la tierra";
    }
}