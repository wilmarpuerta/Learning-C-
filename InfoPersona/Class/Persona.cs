namespace Clases {
    public class Persona{
        public string Nombre = "wilmar";
        public string Apellido = "puerta";
        public string Correo = "wilmar@gmail.com"; 
        public int Edad = 20;


        public string  MostrarInformacion(){
            return $"Hola me llamo {Nombre} {Apellido} tengo {Edad} y este es mi correo: {Correo}";
        }

        public string Actualizar(){
            return $"Hola me llamo {Nombre} {Apellido} tengo {Edad} y este es mi correo: {Correo}";
        }


    }
}