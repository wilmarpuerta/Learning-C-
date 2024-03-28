namespace clases.Models;

// Clase poder
public class SuperPoder
{
    public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;

    // Constructor
    public SuperPoder(){
        Nivel = NivelPoder.NivelUno;
    }
}

// Enumeracion de poderes
public enum NivelPoder {
    NivelUno,
    NivelDos,
    NivelTres
}