using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dz23
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Введите число: ");
             int n = Convert.ToInt32(Console.ReadLine());
           FactorialAsync(n);
            Console.WriteLine("End of Main");
            Console.ReadKey();
        }
        static void Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Thread.Sleep(100);
            Console.WriteLine($"Факториал равен {result}");
          
        }
        static async void FactorialAsync(int n)
        {
            Console.WriteLine("Начало метода "); 
            await Task.Run(() => Factorial(n));              
            Console.WriteLine("Конец метода FactorialAsync");
        }

   
    }
}
