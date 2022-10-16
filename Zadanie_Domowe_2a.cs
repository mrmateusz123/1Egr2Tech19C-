using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Testcs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /* zad 1
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if ((a + b) % 2 == 0)
            {
                Console.WriteLine("Tak");
            }
            else
            {
                Console.WriteLine("Nie");
            }
            zad 2 
            int a = int.Parse(Console.ReadLine());
            int g = int.Parse(Console.ReadLine());
            if (((a + g) / 2) > (Math.Sqrt(a * g)))
            {
                Console.WriteLine("Tak");
            }
            else
            {
                Console.WriteLine("Nie");
            } 
            zad 3
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (k==l && l==m)
            {
                Console.WriteLine("Są 3 takie same");
            }
            else 
            {
                if (k == l)
                {
                    Console.WriteLine("Tak");
                    Console.WriteLine(k);
                }
                else
                {
                    if (k == m)
                    {
                        Console.WriteLine("Tak");
                        Console.WriteLine(k);
                    }
                    else
                    {
                        if (m == l)
                        {
                            Console.WriteLine("Tak");
                            Console.WriteLine(m);
                        }
                        else
                        {
                            Console.WriteLine("Nie ma");
                        }
                    }
                }
            } 
            zad 4
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int w = 0;
            if (a <= b && a <= c && a <= d)
            {
                w = a;
            }
            if (b <= a && b <= c && b <= d)
            {
                w = b;
            }
            if (c <= b && c <= a && c <= d)
            {
                w = c;
            }
            if (d <= b && d <= c && d <= a)
            {
                w = d;
            }
            Console.WriteLine(w);
            
            zad 5 
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine("Tak");
            }
            else
            {
                Console.WriteLine("Nie");
            }
            
            Zad 6
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int n = 0;
            int m = 0;
            if (a==b || a==c || b==c)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Trójkąt ostrokątny");
                }
                else
                {
                    if (a == b)
                    {
                        if (a > c)
                        {
                            Console.WriteLine("Trójkąt ostrokątny");
                        }
                        else
                        {
                            Console.WriteLine("Trójkąt rozwartokątny");
                        }
                    }
                    if (a == c)
                    {
                        if (a > b)
                        {
                            Console.WriteLine("Trójkąt ostrokątny");
                        }
                        else
                        {
                            Console.WriteLine("Trójkąt rozwartokątny");
                        }
                    }
                    if (c == b)
                    {
                        if (b > a)
                        {
                            Console.WriteLine("Trójkąt ostrokątny");
                        }
                        else
                        {
                            Console.WriteLine("Trójkąt rozwartokątny");
                        }
                    }
                }
            }
            else
            {
                if (a>b && a>c)
                {
                    n = a * a;
                    m = c * c + b * b;
                }
                if (b > a && b > c)
                {
                    n = b * b;
                    m = c * c + a * a;
                }
                if (c > b && c > a)
                {
                    n = c * c;
                    m = a * a + b * b;
                }
                if (m==n)
                {
                    Console.WriteLine("Trójkąt protokątny");
                }
                if (m > n)
                {
                    Console.WriteLine("Trójkąt ostrokątny");
                }
                if (m < n)
                {
                    Console.WriteLine("Trójkąt rozwartokątny");
                }
            }
            */
                Console.ReadKey();
        }
    }
}
