using System;

namespace UsoDeConstantes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int VALOR = 5;
            //se recomeinda usar el nombre de las constantes en mayusculas para diferenciar una constante de una variable

            const int VALOR2 = 7;

            Console.WriteLine("El valor de la constante es: {0}", VALOR, VALOR2);


    
            const double PI = 3.1416;

            Console.WriteLine("Introduce la medida del radio");

            double radio = double.Parse(Console.ReadLine());

            //double area = radio * radio * PI;

            double area = Math.Pow(radio,2)*PI;

            Console.WriteLine($"El area del circulo es: {area}");
        }
    }
}
