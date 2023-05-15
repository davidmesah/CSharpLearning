using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {           
            int num1 = 0; int num2 = 0;
            Console.WriteLine("Calculadora en C#\r");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Escriba su Primer Digito");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba su Segundo Digito");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Elija una opcion, para realizar la operacion:");
            Console.WriteLine("\ta - SUMAR");
            Console.WriteLine("\ts - RESTAR");
            Console.WriteLine("\tm - MULTIPLICAR");
            Console.WriteLine("\td - DIVIDIR");
            Console.Write("Cual es su Opcion? ");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Su Resultado es: {num1} + {num2} = " + (num1 + num2));
                case "s":
                    Console.WriteLine($"Su Resultado es: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Su Resultado es: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Su Resultado es: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            Console.Write("Presione Cualquier tecla para cerrar la app...");
            Console.ReadKey();
        }
    }
}