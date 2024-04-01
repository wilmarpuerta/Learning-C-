using clases.Interface;

namespace clases;

public class ImprimirInfo
{
    public void ImprimirSuperHeroe(ISuperHeroe superHeroe)
    {
        Console.WriteLine($"Id: {superHeroe.Id}");
        Console.WriteLine($"Nombre: {superHeroe.Nombre}");
        Console.WriteLine($"Identidad secreta: {superHeroe.IdentidadSecreta}");
    }
}