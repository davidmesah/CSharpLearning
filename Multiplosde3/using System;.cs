using System;

namespace matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar una matriz
        
            int[,] tabla= new int[3,4];

            for(int i=0; i<3;i++)
            {
                for(int j=0; j<4; j++)
                {
                    Console.WriteLine("Ingrese un valor numerico");
                    tabla[i,j]= int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("Imprimir matriz");



            for(int i=0; i<3;i++)
            {
                for(int j=0; j<4; j++)
                {
                    Console.Write(tabla[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}