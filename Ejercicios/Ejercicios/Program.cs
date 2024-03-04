﻿
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

string nameUser;
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