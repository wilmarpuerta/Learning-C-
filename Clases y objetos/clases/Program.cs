
// Objeto de poderes

SuperPoder dinero = new SuperPoder();
dinero.Nombre = "Dinero";
dinero.Descripcion = "El poder del bolsillo :v";
dinero.Nivel = NivelPoder.NivelDos;

SuperPoder condicionFisica = new SuperPoder();
condicionFisica.Nombre = "Condición física al máximo";
condicionFisica.Descripcion = "El poder de entrenar tu cuerpo al maximo";
condicionFisica.Nivel = NivelPoder.NivelDos;

// Objeto de heroe
SuperHeroe batman = new SuperHeroe();

batman.Id = 1;
batman.Nombre = "Batman";
batman.IdentidadSecreta = "Bruce Wayne";
batman.Ciudad = "Ciudad Gótica";
batman.PuedeVolar = false;
// Creacion de lista de poderesS
List<SuperPoder> poderesBatman = new List<SuperPoder>();
poderesBatman.Add(dinero);
poderesBatman.Add(condicionFisica);

batman.SuperPoderes = poderesBatman;
// Llamado del metodo de la clase
batman.UsarSuperPoder();

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

// Clase poder
class SuperPoder{
    public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;

    // Constructor
    public SuperPoder(){
        Nivel = NivelPoder.NivelUno;
    }
}

// Enumeracion de poderes
enum NivelPoder {
    NivelUno,
    NivelDos,
    NivelTres
}