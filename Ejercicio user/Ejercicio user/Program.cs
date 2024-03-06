// Ejercicio de usuario

Console.WriteLine("Ingresa el nombre de usuario:");
string user = Console.ReadLine();
Console.WriteLine("Ingresa una contraseña que conlleve '-':");

while (true)
{
    string? pass = Console.ReadLine();

    char[] passSplit = pass.ToCharArray();
    pass = "";

    foreach (var word in passSplit)
    {
        pass += $"{word}-";
    }

    if (passSplit.Length >= 1)
    {
        Console.WriteLine("Contraseña valida");
        Console.WriteLine($"Tu contraseña es: {pass}");
        break;
    }
    else
    {
        Console.WriteLine("\nContraseña invalida\nVuelve a digitar contraseña");
    }
    
}

