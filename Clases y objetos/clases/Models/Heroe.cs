namespace clases.Models;

public abstract class Heroe
{
    public abstract string SalvarElMundo();

    public virtual string SalvarLaTierra()
    {
        return $"Ha salvado la tierra";
    }
}