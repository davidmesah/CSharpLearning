using System;

namespace Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            double c=0,f=0,cons=9/5;
            Console.WriteLine("Ingrese los grados centigrados");
            c= double.Parse(Console.ReadLine());
            //f=((double)9/5)*c+32;
            f=1.8*cons*c+32;
            Console.WriteLine("{0} grados centigrados, equivalen a {1} grados farenheit",f);
        }
    }
}
