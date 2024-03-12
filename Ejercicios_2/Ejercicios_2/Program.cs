
// <-------------------------- Ejercicios de practica ----------------------------->

// Escribir un programa que pida al usuario dos números y determine si ambos son pares.

// Console.WriteLine("\nIngresa un numero entero:");
// int numberA = int.Parse(Console.ReadLine());
//
// Console.WriteLine("\nIngresa otro numero entero:");
// int numberB = int.Parse(Console.ReadLine());
//
// if ((numberA % 2 == 0) && (numberB % 2 == 0))
// {
//     Console.WriteLine("\nEl primer numero y el segundo son pares");
// }
// else if ((numberA % 2 == 0) && (numberB % 2 != 0))
// {
//     Console.WriteLine("\nEl primer numero es par y el segundo no es par");
// }
// else if ((numberB % 2 == 0) && (numberA % 2 != 0))
// {
//     Console.WriteLine("\nEl primer numero no es par y el segundo es par");
// }
// else
// {
//     Console.WriteLine("\nNingun de los dos numeros es par");
// }


// Crear un programa que solicite al usuario su edad y su género ('M' para masculino
// y 'F' para femenino) y determine si la persona es elegible para jubilarse,
// considerando que debe tener al menos 60 años si es hombre o 55 años si es
// mujer.
/*
Console.WriteLine("Ingrese su edad:");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su genero (M para masculino | F para femenino):");
string? gender = Console.ReadLine();

if (gender == "f" || gender == "F")
{
    if (age >= 55)
    {
        Console.WriteLine("Ya puedes jubilarte");
    }
    else
    {
        Console.WriteLine($"Oh te faltan {55 - age} años para jubilarte ");
    }
}
else if (gender == "m" || gender == "M")
{
    if (age >= 60)
    {
        Console.WriteLine("Que bien ya puedes jubilarte");
    }
    else
    {
        Console.WriteLine($"Oh te faltan {60 - age} años para jubilarte ");
    }
}
else
{
    Console.WriteLine("Ingresaste mal los datos :(");
}*/


// Escribir un programa que determine si un año es bisiesto. Un año es bisiesto si es
// divisible por 4 pero no por 100, excepto si también es divisible por 400.

/*
Console.WriteLine("Ingrese un año:");
int year = int.Parse(Console.ReadLine());

if (year % 4 == 0 || (year % 100 != 0 && year % 400 == 0))
{
    Console.WriteLine("El año ingresado es bisiesto");
}
else
{
    Console.WriteLine("El año ingresado no es bisiesto");
}
*/

// Crear un programa que solicite al usuario su nombre y su edad, y determine si
// puede obtener un descuento en el cine. Para obtener el descuento, la persona
// debe tener menos de 18 años o más de 60 años.

/*
Console.WriteLine("Ingrese su nombre:");
string? name = Console.ReadLine();

Console.WriteLine("Ingrese su edad:");
int age = int.Parse(Console.ReadLine());

    if (age < 18 || age > 60)
    {
        Console.WriteLine($"{name} obtuviste un descuento en el cine");
    }
    else
    {
        Console.WriteLine($"{name} obtuviste un descuento en el cine");
    }
*/


// Escribir un programa que simule un sistema de autenticación simple. El programa
// debe solicitar al usuario un nombre de usuario y una contraseña. Si el nombre de
// usuario es 'admin' y la contraseña es '1234', el programa debe imprimir "Acceso
// concedido"; de lo contrario, debe imprimir "Acceso denegado"

/*
string name = "admin";
string pass = "1234";

Console.WriteLine("Ingrese su nombre de usuario"); 
string? loginName = Console.ReadLine();

Console.WriteLine("Ingrese su nombre de usuario"); 
string? loginPass = Console.ReadLine();

if (loginName == name && loginPass == pass)
{
    Console.WriteLine("Acceso concedido");
}
else
{
    Console.WriteLine("Acceso denegado");
}
*/


// Crear un programa que pida al usuario tres números y determine si al menos uno de ellos es negativo.

/*
int numberA;
int numberB;
int numberC;

Console.WriteLine("Ingresa el valor del primer numero:");
numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa el valor del segundo numero:");
numberB = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa el valor del tercer numero:");
numberC = int.Parse(Console.ReadLine());

if (numberA < 0 || numberB < 0 || numberC < 0)
{
    Console.WriteLine("En los numeros ingresados hay negativos");
}
else
{
    Console.WriteLine("En los numeros ingresados no hay negativos");
}

if (numberA < 0)
{
    Console.WriteLine($"El primer numero es negativo: {numberA}");
}
else if (numberB < 0)
{
    Console.WriteLine($"El segundo numero es negativo: {numberB}");
}
else if (numberC < 0)
{
    Console.WriteLine($"El tercer numero es negativo: {numberC}");
}
*/


// Solicita al usuario ingresar una temperatura en grados Celsius y conviértela a
// grados Fahrenheit utilizando la fórmula de conversión adecuada.
// double celsius;
// double fahrenheit;


/*Console.WriteLine("Ingrese la temperatura en grados Celsius");
double? numero = double.Parse(Console.ReadLine());

double? fahrenheit = (numero * 9 / 5) + 32;

Console.WriteLine($"Tu temperatura en Fahrenheit es:{fahrenheit}");*/



// Realizar un programa que pida cargar un mes, luego verificar si dicho mes
// corresponde a Halloween o Navidad, validar que se pueda ingresar un mes
// correcto

/*using System.Text.RegularExpressions;

while (true)
{
    Console.WriteLine("Ingresa un mes del año");
    string? month = Console.ReadLine();
    
    bool monthInt = Regex.IsMatch(month, "^(1[0-2]|0[1-9]||[1-9])$");
    bool monthString = Regex.IsMatch(month, "^(enero|febrero|marzo|abril|mayo|junio|julio|agosto|septiembre|octubre|noviembre|diciembre)$", RegexOptions.IgnoreCase);
    
    if (monthInt == true || monthString == true)
    {
        if (month == "10" || month.ToLower() == "octubre")
        {
            Console.WriteLine("El mes ingresado coresponde a Halloween");
        }
        else if (month == "12" || month.ToLower() == "diciembre")
        {
            Console.WriteLine("El mes ingresado coresponde a Navidad");
        }
        else
        {
            Console.WriteLine("El mes ingresado no coresponde a Halloween o Navidad");
        }
        break;
    }
    else
    {
        Console.WriteLine("El valor ingresado no corresponde a un mes");
    }
}*/


// Solicita al usuario ingresar las longitudes de los lados de un triángulo y determina
// si es equilátero, isósceles o escaleno.

/*Console.WriteLine("Ingresa el valor del lado A del triangulo");
int? ladoA = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa el valor del lado B del triangulo");
int? ladoB = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa el valor del lado C del triangulo");
int? ladoC = int.Parse(Console.ReadLine());

if (ladoA == ladoB && ladoB == ladoC && ladoC == ladoA)
{
    Console.WriteLine("El triangulo es equilátero");
}
else if (ladoA == ladoB || ladoB == ladoC || ladoC == ladoA)
{
    Console.WriteLine("El triangulo es isósceles");
}
else if (ladoA != ladoB && ladoB != ladoC && ladoC != ladoA)
{
    Console.WriteLine("El triangulo es escaleno");   
}*/


// Se ingresan por teclado tres números, si todos los valores ingresados son
// menores a 10, imprimir en consola "Todos los números son menores a diez"

/*Console.WriteLine("Ingresa un numero aleatorio");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa otro numero aleatorio");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa otro numero aleatorio");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 < 10 && number2 < 10 && number3 < 10)
{
    Console.WriteLine("Todos los números son menores a diez");
}
else if (number1 > 10 && number2 > 10 && number3 > 10)
{
    Console.WriteLine("Todos los números son mayores a diez");
}
else
{
    Console.WriteLine("No todos los numeros son menores a diez");
}*/


// Crea un programa que solicite al usuario el monto total de la factura y el
// porcentaje de propina que desea dejar. Luego, calcula el monto de la propina 
// muestra el total a pagar


/*Console.WriteLine("Ingresa el monto total de la factura");
int monto = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa el porcentaje de la propina que desea dejar");
double propina = Convert.ToDouble(Console.ReadLine());

double porcentaje = monto * */