using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp23
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            FrackAsync(n);
            Sum(n);

            Console.ReadKey();
        }
        static void Frack(int n)
        {
            int f = 1;
            for (int i =1; (i-1) < n; i++)
            {
                f *= i;
                
                Thread.Sleep(100);
                Console.WriteLine(f);
            }
            
        }
        static void Sum(int n)
        {
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                s += i;
                Thread.Sleep(10);
                Console.WriteLine(s);
            }
            //Console.WriteLine(s);
        }
        static async void FrackAsync(int n)
        {
            await Task.Run(() => Frack(n));
            //await Task.Run(() => Sum(n));

        }
    }
}
