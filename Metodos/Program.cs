using System;

namespace Metodos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            EscribeAlgo();
            EscribeAlgoEspecifico("Soy un argumento y me llamaron desde un método");
            Console.Read();
            
        }

        //Estructura de un Método-- NivelDeAcceso - (static) - TipoDeRetorno - NombreDelMetodo (Parámetro1, Parámetro2)
        public static void EscribeAlgo()
        {
            Console.WriteLine("Yo nací en un método");
            
        }

        public static void EscribeAlgoEspecifico(string miTexto)
        {
            Console.WriteLine(miTexto);
        }
    }
}
