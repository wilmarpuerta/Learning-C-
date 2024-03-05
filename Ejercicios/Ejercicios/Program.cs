﻿/*
// Area de un rectangulo

double ladoA;
double ladoB;

Console.WriteLine("Area del retangulo");

Console.WriteLine("Ingresa el valor del lado A:");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingresa el valor del lado B:");
ladoB = Convert.ToDouble(Console.ReadLine());

double result = ladoA * ladoB;

Console.WriteLine($"El area del retangulo es de: {result}");


// Radio de un circulo 

var radio = 0d;
var resultado = 0d;

Console.WriteLine("Bienvenido, calculemos circulos!");
Console.WriteLine("Ingresa el valor del radio");
radio = Convert.ToDouble(Console.ReadLine());

resultado = Math.PI * radio * radio;

Console.WriteLine($"El área de tu circulo es de {resultado}");

// Grupo etario

string? nameUser;
double ageUser;
string ageGroup = "";
Console.WriteLine("Ingrese su nombre:");
nameUser = Console.ReadLine();

Console.WriteLine("Ingrese su edad:");
ageUser = Convert.ToDouble(Console.ReadLine());

if (ageUser < 0)
{
    Console.WriteLine("Ingresa un numero valido!!");
}
else
{
    if (ageUser <= 5)
    {
        ageGroup = "Primera Infancia";
    } else if (ageUser >= 6 && ageUser <= 11)
    {
        ageGroup = "Infancia";
    } else if (ageUser >= 12 && ageUser  <= 18)
    {
        ageGroup = "Adolescencia";
    } else if (ageUser >= 19 && ageUser  <= 26)
    {
        ageGroup = "Juventud";
    } else if (ageUser >= 27 && ageUser  <= 59)
    {
        ageGroup = "Adultez";
    } else
    {
        ageGroup = "Persona Mayor";
    }
}

Console.WriteLine($"El grupo etario de {nameUser} es de {ageGroup}");
*/
// Juego del casino
var random = new Random();

int manoJugador = 0;
int manoDiler = random.Next(1,12) + random.Next(1,12);
string? nameJugador = "";
string? switchControl = "Menu";
string? res = "";

Console.WriteLine("Para iniciar ingrese su nombre:");
nameJugador = Console.ReadLine();

Console.WriteLine("\n<<-------------- Bienvenido al CASINO --------------->>\n");

while (true)
{
    switch (switchControl)
    {
        case "Menu":
            Console.WriteLine("Ingresa 21 para jugar Blackjack");
            switchControl = Console.ReadLine();
            break;
        
        case "21":
            Console.WriteLine($"\n<<-------------- Bienvenido al Blackjack --------------->>\n");
            do
            {
                int num = random.Next(1, 12);
                manoJugador = manoJugador + num;
                Console.WriteLine(
                    $"Toma tu carta {nameJugador}\nTe salió el numero {num}\nQuieres tomar otra carta:\ny/n");
                res = Console.ReadLine();

            } while (res is "y" or "Y");

            switch (res)
            {
                case "n":
                    if (manoJugador > 21)
                    {
                        Console.WriteLine($"Oh no! te pasaste de 21\nTu mano quedo en {manoJugador}");   
                    }
                    else if (manoJugador <= 21 && manoJugador > manoDiler)
                    {
                        Console.WriteLine($"Felicidades le has ganano al diler\nLa mano del diler era {manoDiler}");
                    }
                    else
                    {
                        Console.WriteLine($"Oh no! ha ganano el diler\nLa mano del diler era {manoDiler}");
                    }
                    
                    Console.WriteLine("Quieres volver a jugar?\ny/n");
                    res = Console.ReadLine();
                    manoJugador = 0;
                    manoDiler = 0;
                    break;
            }
            break;
        
        default:
            Console.WriteLine("Valor ingresado no valido");
            switchControl = "Menu";
            break;
    }

}