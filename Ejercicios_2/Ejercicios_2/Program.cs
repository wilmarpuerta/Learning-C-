
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
double porcentaje = Convert.ToDouble(Console.ReadLine());

double propina = (porcentaje / 100) * monto;

Console.WriteLine($"El monto a pagar es de {propina + monto}");*/


// Pide al usuario ingresar el precio de un producto y el porcentaje de descuento
// aplicable. Luego, calcula el precio final después del descuento.

/*Console.WriteLine("Ingresa el precio del producto");
int monto = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa el porcentaje de descuento");
double porcentaje = Convert.ToDouble(Console.ReadLine());

double propina = (porcentaje / 100) * monto;

Console.WriteLine($"El total a pagar es de {monto - propina}");*/


// Se ingresan tres valores por teclado, si todos son iguales se imprime la suma del
// primero con el segundo y a este resultado se lo multiplica por el tercero

/*int valor1, valor2, valor3;

Console.WriteLine("Ingresa el primer numero");
valor1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa el segundo numero");
valor2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa el tercer numero");
valor3 = Convert.ToInt32(Console.ReadLine());

if (valor1 == valor2 && valor2 == valor3)
{
    Console.WriteLine($"Los tres numeros son iguales. se realiza la siguiente operacion:\nSe suman los dos primeros valores y se multiplican por el tercer numero\nEl resultado es el siguiente:\n{(valor1 + valor2) * valor3}");
}
else
{
    Console.WriteLine("Los numeros ingresados no son iguales");
}*/


// De un operario se conoce su sueldo y los años de antigüedad. Se pide
// confeccionar un programa que lea los datos de entrada e informe:
// a) Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años,
// otorgarle un aumento del 20 %, mostrar el sueldo a pagar.
// b) Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años, otorgarle
// un aumento de 5 %. mostrar el sueldo a pagar.
// c) Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios.
// mostrar el sueldo a pagar.


/*Console.WriteLine("Ingresa el sueldo del operario:");
int sueldo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa los años de antigüedad del operario:");
int ageAntiguedad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe");

if (sueldo < 500 && ageAntiguedad >= 10)
{
    Console.WriteLine($"Al operario se le otorga un aumento del 20 %, total de sueldo: {sueldo + ((sueldo * 20 )/ 100)}");
}
else if (sueldo < 500 && ageAntiguedad < 10)
{
    Console.WriteLine($"Al operario se le otorga un aumento del 5 %, total de sueldo: {sueldo + ((sueldo * 5) / 100)}");
}
else if (sueldo > 500 )
{
    Console.WriteLine($"Al operario no se le otorga un aumento, total de sueldo: {sueldo}");
}*/


// <---------------------------------- Parte 2 Ejercicios ----------------------------------->

// Suma de números pares e impares:

// Escribe un programa que solicite al usuario un número entero positivo X y luego calcule la
// suma de los números pares y la suma de los números impares desde 1 hasta X. Finalmente,
// muestra ambas sumas.

/*
int x, pares = 0, impares = 0;

Console.WriteLine("Escribe un numero entero;");
x = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
    if (i % 2 == 0)
    {
        pares = pares + i;
    }
    else
    {
        impares = impares + i;
    }
}

Console.WriteLine($"La suma de los numeros pares del 1 hasta el {x} es: {pares}\nLa suma de los numeros impares del 1 hasta el {x} es: {impares}");
*/


// Tabla de multiplicar:

// Pide al usuario que ingrese un número entero y muestra la tabla de multiplicar
// correspondiente a ese número, desde 1 hasta 10.


int x;

Console.WriteLine("Escribe un numero entero;");
x = Convert.ToInt32(Console.ReadLine());




// Secuencia de Collatz:

// Escribe un programa que tome un número inicial del usuario y muestre la secuencia de
// Collatz para ese número. La secuencia de Collatz se define como sigue: Si el número es
// par, divídelo por 2; si es impar, multiplícalo por 3 y súmale 1. Repite este proceso hasta
// que el número sea igual a 1.

/*int N;
do
{
    Console.WriteLine("Ingresa un numero entero:");
    N = Convert.ToInt32(Console.ReadLine());

} while ( N <= 0 );

while (true)
{
    if (N == 1)
    {
        Console.WriteLine("El numero es igual a 1");
        break;
    }
    else if (N % 2 == 0)
    {
        N = N / 2;
        Console.WriteLine("El numero es par entonces se divide por 2");
    }
    else
    {
        N = N * 3 + 1;
        Console.WriteLine("El numero es impar entonces se multiplica por 3 y se le suma 1");
    }
}*/


// Secuencia Fibonacci:

// Pide al usuario un número entero N y muestra los primeros N términos de la secuencia
// Fibonacci. La secuencia Fibonacci comienza con 0 y 1, y cada término subsiguiente es la
// suma de los dos términos anteriores.


/*Console.WriteLine("Ingresa un numero entero:");
int N = Convert.ToInt32(Console.ReadLine());

int Fn1 = 0;
int Fn2 = 1;
int suma = 0;

if (N != 0)
{
    for (int i = 0; i < N; i++)
    {
        if (N == 1 || N == 2)
        {
            suma = N;
            break;
        }

        suma = Fn1 + Fn2;

        if (suma == N || suma > N)
        {
            Console.WriteLine($"Estos son los numeros de Fibonacci que estan por debajo de {N}");
            break;
        }

        Console.WriteLine($"La secuencia de Fibonacci es {suma}");

        Fn1 = Fn2;
        Fn2 = suma;
    }
}*/

