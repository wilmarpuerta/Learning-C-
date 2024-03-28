namespace clases.Models;

public class AntiHeroe : SuperHeroe
{
    public string RealizarAccionAntiHeroe(string accion)
    {
        return $"El AntiHeroe {NombreIdentidadSecreta} ha realizado la accion de {accion}";
    }
}