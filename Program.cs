using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace задание_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int n = int.Parse(Console.ReadLine());

             Fact(n);


            Console.ReadLine();
        }
        private static async Task Fact(int n)
        {


         
            int factorial = 1;   

            for (int i = 2; i <= n; i++) 
            {
                factorial = factorial * i;
            }

            Console.WriteLine($"Факториал числа  = {factorial}");
            await Task.Delay(1000);
        }
   

    }
}