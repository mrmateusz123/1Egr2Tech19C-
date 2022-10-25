using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testcs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zad 1
            /*
            for (int i = 0; i < 31;i++)
                Console.WriteLine(i);
       
            // Zad 2
            Console.WriteLine("Ile liczb nieparzystych:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n * 2 + 1; i++)
                if (i % 2 == 1)
                {
                    Console.WriteLine(i * i);
                }
            
            // Zad 3
            for (int i=1000;i<10000;i++)
                if (i % 379 == 0)
                {
                    Console.WriteLine(i);
                }
            
            // Zad 4
            for (int i = 100; i < 1000; i++)
                if (i % 5 == 0 || i%6==0 || i%11==0)
                {
                    Console.WriteLine(i);
                }
            
            // Zad 5
            Console.WriteLine("Ile liczb:");
            int n = int.Parse(Console.ReadLine());
            int w = 0;
            int t = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Liczba");
                t = int.Parse(Console.ReadLine());
                w = w + t;
            }
            Console.WriteLine(w);
            
            // Zad 6
            int l = int.Parse(Console.ReadLine());
            int k = 0;
            for (int i = 0; i < l*2+1; i++)
            {
                if (i % 2 == 0)
                {
                    k = k + i;
                }
            }
            Console.WriteLine(k);
            
            int m = 0;
            for (int i = 11; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    m = m + i;
                }
            }
            Console.WriteLine(m);
            
            // Zad 8
            // Zad 9
            Console.WriteLine("Podaj ile liczb:");
            int n = int.Parse(Console.ReadLine());
            int w = 0;
            int t = -79;
            int q = 21;
            for (int i = 21; i < n * 21 + n * 100; i++)
            {
                if (q == i)
                {
                    w = w + i;
                    t = t + 100;
                    q = q - 1;
                }
                else
                {

                    i = i + 99;
                    w = w + i;
                    t = t + 100;
                }
            }
            Console.WriteLine(w - t);
            
            // Zad 10
            int w2 = 0;
            int w = 0;
            int t = 0;
            int t2 = 0;
            int o = 10;
            for (int i = 0; i < 1000; i++)
            {
                o = 10;
                if (i>100)
                {
                    o = o + 990;
                }
                else if (i > 10)
                {
                    o = o + 90;
                }
                i = i - w;
                t = i * i - (o * t2);
                if (t<0)
                {
                    w = 0;
                }
                if (t > 0)
                {
                    if (i==t)
                    {
                        Console.WriteLine(i);
                    }
                    else if (t>10)
                    {
                        t2 = t2 + 1;
                        w = w + 1;
                    }
                }
            }

            Console.ReadKey();
            */
        }
    }
}