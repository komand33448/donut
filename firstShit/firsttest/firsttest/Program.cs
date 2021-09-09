using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firsttest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            int b = 5;

            Console.WriteLine("Hello World!");

            if(a + b == 15)
            {
                Console.WriteLine("yo thats sick");
            }
        

            //mit første forsøg på at lave en donut, det gik elendigt
            //så har tænkt mig at lave det med en formel istedet for
            Console.WriteLine
                (@"

          00000000000000
        000000000000000000
      000000 00000000 000000
    000000 000000000000 000000
  000000 0000000000000000 000000
000000 00000000000000000000 000000
000000 00000000000000000000 000000
000000 00000000000000000000 000000
000000 00000000000000000000 000000
  000000 0000000000000000 000000
    000000 000000000000 000000
      000000          000000
        000000000000000000
          00000000000000


                ");

            //tester lige hvordan man bruger formler i C# ved at prøve at lave forskellige former

            int borderSizeL = 1;
            int bordersizeR = 19;
            int bordersizeB = 0;
            int bordersizeT = 9;
            for (int q = 0; q < 10; q = q + 1)
            {
                for (int z = 1; z < 20; z = z + 1)
                {
                
                    if(z == borderSizeL || z == bordersizeR || q == bordersizeB || q == bordersizeT || z + q == 20)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("0");
                    }

                }
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine();


            for (int q = 0; q < 10; q = q + 1)
            {
                for (int z = 1; z < 20; z = z + 1)
                {
                    if(z % 2 == 0 || q % 2 == 0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("█");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            string bruh = "bruh sound";
            string NotBruh = "This is not bruh...";

            for(int hund = 1; hund < 10; hund = hund + 1)
            {
                if(hund % 2 == 0)
                {
                    Console.WriteLine(bruh);
                }
                else
                {
                    Console.WriteLine(NotBruh);
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            //det her er begyndelsen af min donut den er ikke færdig i nu
            //men jeg laver den færdig til næste deadline

            int testTal1 = 16;
            int testTal2 = 16;

            for(int h = 0; h <= testTal2; h++)
            {
                for(int w = 0; w <= testTal1; w++)
                {
                    if(h == 8 && w == 8)
                    {
                        Console.WriteLine("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }                    
                }
                Console.WriteLine();
            }


            int r = 10;
            float pi = 3.1314f;

            Console.Write(2 * pi * r);


            

        }
    }
}
