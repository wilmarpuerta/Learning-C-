// Ejercicio de usuario

string? nameUser = "";
string? lastNameUser = "";
string? clanUser = "";
int idUser = 0;
string? res = "";
string? loginUser = "";
string? loginPassword = "";

Console.WriteLine("Ingresa tu nombre");
nameUser = Console.ReadLine();

Console.WriteLine("Ingresa tu apellido");
lastNameUser = Console.ReadLine();

Console.WriteLine("Ingresa tu clan");
clanUser = Console.ReadLine();

Console.WriteLine("Ingresa tu identificacion");
idUser = int.Parse(Console.ReadLine());

Console.WriteLine("<----- Bienvenido al login -------->\n");

while (true)
{
do
{
    Console.WriteLine("Ingresa tu usuario");
    loginUser = Console.ReadLine();
    Console.WriteLine("Ingresa una contraseña:");
    loginPassword = Console.ReadLine();
    
    Console.WriteLine("Esta seguro de sus credenciales?\ny/n");
    res = Console.ReadLine();
} while (res == "n" || res == "N");

string passwordUser = $"{nameUser}-{lastNameUser}-{clanUser}-{idUser}";


    if (nameUser == loginUser && passwordUser == loginPassword)
    {
        Console.WriteLine($"Contraseña valida\nBienvenido {nameUser}");
        break;
    }
    else
    {
        Console.WriteLine("\nContraseña invalida\nVuelve a digitar contraseña");
    }
    
}

