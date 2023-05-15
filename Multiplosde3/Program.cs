using System;

namespace Multiplosde3
{
    class Program
    {
        static void Main(string[] args)
        {
            int acu=0;
            for(int i=3; i<100;i+=3)
            {
                Console.WriteLine(i);
                
                acu+=i; //acu=acu+i
            }

            Console.WriteLine("Los multiplos de tres son: "+ acu);
        }
    }
}
