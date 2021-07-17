using System;

namespace Metodos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string amigo1 = "Marco";
            string amigo2 = "Antonio";
            string amigo3 = "Jesus";

            SaludarAmigo(amigo1,amigo2, amigo3);
            
            

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

        public static void SaludarAmigo(string nombreAmigo1, string nombreAmigo2, string nombreAmigo3)
        {
            Console.WriteLine("¡Hola " + nombreAmigo1 + " , que tengas buen dia");
            Console.WriteLine("¡Hola " + nombreAmigo2 + " , que tengas buen dia");
            Console.WriteLine("¡Hola " + nombreAmigo3 + " , que tengas buen dia");
        }
    }
}
