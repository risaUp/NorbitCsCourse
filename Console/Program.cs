using System;
using MyLib;

namespace ConsoleE
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите целое положительное число");
            int? N = Convert.ToInt32(Console.ReadLine());
            N.WriteNum();

            Console.WriteLine(" ");
            Console.WriteLine("Введите целое нечетное положительное число");
            N = Convert.ToInt32(Console.ReadLine());
            N.WriteStars();
        }
    }
}
