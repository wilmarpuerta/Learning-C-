using Clases;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/clientes", () =>{
    Cliente prueba = new Cliente();
    return prueba.MostrarInformacion();
});

app.MapGet("/actualizar", () =>{
    Cliente prueba = new Cliente();
    prueba.Nombre="Juan";
    return prueba.Actualizar();
});

app.MapGet("/salario", () =>{
    Empleado prueba = new Empleado();
    return prueba.CalcularSalario();
});

app.MapGet("/newSalario", () =>{
    Empleado prueba = new Empleado();
    prueba.salario = 500000;
    return prueba.CalcularSalario();
});

app.Run();
