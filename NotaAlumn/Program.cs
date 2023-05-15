using System;

namespace NotaAlumn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            int Nota=0; 
            int mayor=0, menor=0, Total=0;
            int promed=0;
            for(int i=1; i<=5; i++)

            {
            
               Console.WriteLine("Ingrese las notas del alumno entre 0 y 10");
               Nota= int.Parse(Console.ReadLine());

                if (i==1)
               {
                   mayor=Nota;
                   menor=Nota;
               }
               else
               {
                   if (Nota>mayor)
                   {
                      mayor=Nota; 
                   }
                   if (Nota<menor)
                   {
                       menor=Nota;
                   }
               }

            Total=Total+Nota;

            promed=Total/5;

            }

            Console.WriteLine("imprimiendo...");

            for(int i=0; i<=5; i++)
            {
                Console.WriteLine("Las notas son: " + Nota);
            }
      
            Console.WriteLine("La mayor nota es: " + mayor);
            Console.WriteLine("La menor nota es: " + menor);
            Console.WriteLine("El promedio de las notas es: " + promed);

        
        }
    }
}
