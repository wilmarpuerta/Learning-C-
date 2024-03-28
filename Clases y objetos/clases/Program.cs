using clases.Models;
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

// Enumeracion de poderes
enum NivelPoder {
    NivelUno,
    NivelDos,
    NivelTres
}