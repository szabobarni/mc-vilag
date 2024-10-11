using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekurziv_cucc
{
    internal class Program
    {
        static int fib(int n)
        {
            if (n <= 1) 
            {
                return 1;
            }
            else 
            {
                return n+fib(n-1);
            }
        }
        public static int osszegzes(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + osszegzes(n - 1);
            }
        }

        public static int hatvany(int szam, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return szam;
            }
            else
            {
                return szam * hatvany(szam, n - 1);
            }
        }
        static bool Eldönt(int n, int[] mag)
        {
            if (n == 0)
            {
                return false;
            }
            if (mag[n] > 200)
            {
                return true;
            }
            else
            {
                return Eldönt(n - 1, mag);
            }
        }
        static int Megszamlalas(string szoveg, int jobb)
        {
            if (jobb == 0)
            {
                return 0;
            }
            else
            {
                if (szoveg[jobb] == ' ')
                {
                    return 1 + Megszamlalas(szoveg, jobb - 1);
                }
                else
                {
                    return Megszamlalas(szoveg, jobb - 1);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Adjon meg egy számot! ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine($"Eredmény: {osszegzes(szam)}");
            Console.WriteLine("---------------");

            Console.Write("Hanyadikon? ");
            int kitevo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Eredmény: {hatvany(szam, kitevo)}");
            Console.WriteLine("---------------");

            Console.Write("Hanyadik elem? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Eredmény: {fib(n)}");
            Console.WriteLine("---------------");

            int[] magas = new int[10] { 180, 170, 190, 155, 188, 199, 200, 200, 192, 188 };
            Console.WriteLine($"Eredmeny: {Eldönt(magas.Length - 1, magas)}");
            Console.WriteLine("---------------");

            Console.WriteLine("Kérek egy szöveget!");
            string beker = Console.ReadLine();
            Console.WriteLine($"Eredmeny: {Megszamlalas(beker, beker.Length - 1)+1}");


        }
    }
}
