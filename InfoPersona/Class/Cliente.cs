namespace Clases {
    public class Cliente : Persona{

        public string tipo_cliente = "Jefe";
        public int puntos = 1000;

        public string CalcularPuntos(){
            return $"Los puntos del cliente son {puntos}";
        }
    }
}