
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

