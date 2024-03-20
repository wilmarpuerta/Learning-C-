namespace Clases {
    public class Empleado : Persona{
       
        public int salario = 2000000;
        public int codigoEmpleado = 23;

        public string CalcularSalario(){
            return $"El salario es de {salario}";
        }   
    }
}