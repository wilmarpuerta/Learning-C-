namespace clases.Models;

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