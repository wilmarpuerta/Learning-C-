

// Concatenar Strings

/*
using System.Runtime.InteropServices.JavaScript;

string stringsConcatenada = "Hoy es: " + DateTime.Now.ToString();
Console.WriteLine(stringsConcatenada);

string stringRepetido = new string('a', 10);
Console.WriteLine(stringRepetido);
*/


// Metodos de strings 

/*string oracion = "Esta es otra oración";
int posicion = oracion.IndexOf(" ") + 1;
Console.WriteLine(posicion);
string nuevaPalabra = oracion.Substring(posicion, oracion.IndexOf(" ", posicion) - posicion);
Console.WriteLine(oracion.IndexOf(" ", posicion));
int cantidad = nuevaPalabra.Length;
Console.WriteLine(cantidad);
Console.WriteLine(nuevaPalabra);*/

// Formateo de valiables

/*DateTime fecha = new DateTime(2024, 3, 8, 16, 30, 56);
double temperatura = 28.5;
string[] estados = ["despejado", "nublado", "lluvioso"];

string resultado = String.Format("A las {0:t} en {1:D}, la temperatura fue {2:F1} celsius con cielo {2}", temperatura, fecha, estados[1]);

Console.WriteLine(resultado);*/

// Metodo de formateo

/*string stringPrueba = "         ";
if (stringPrueba == null || stringPrueba.Equals(String.Empty));
{
    Console.WriteLine("El campo es nulo o vacio");
}

bool nuloVacio = String.IsNullOrEmpty(stringPrueba);
Console.WriteLine(nuloVacio);

if (stringPrueba == null || stringPrueba.Equals(String.Empty) || stringPrueba.Trim().Equals(String.Empty))
{
    Console.WriteLine("El campo es nulo o tiene espacios en blanco");
}

bool withSpace = String.IsNullOrWhiteSpace(stringPrueba);
Console.WriteLine(withSpace);*/


// Arrays

/*
string[] estudiantes = ["Carlos", "Pedro","Juan"];
Array.Sort(estudiantes, StringComparer.Ordinal);
int valorAscci = Console.Read();
Console.WriteLine(valorAscci);
foreach (var estudiante in estudiantes)
{
    Console.WriteLine(estudiante);
}
*/
