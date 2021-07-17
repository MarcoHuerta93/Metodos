using System;

namespace Metodos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            EscribeAlgo();
            EscribeAlgoEspecifico("Soy un argumento y me llamaron desde un método");
            
            Console.WriteLine(Sumar(10,5));
            Console.WriteLine(Multiplica(10,10));
            Console.WriteLine(Dividir(5,3));
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

        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiplica(int numM1, int numM2)
        {
            return numM1 * numM2;
        }

        public static double Dividir(double numDiv1, double numDiv2)
        {
            return numDiv1 / numDiv2;

        }
    }
}
