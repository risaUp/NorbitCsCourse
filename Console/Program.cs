using System;
using ClassLibrary;

namespace ConsoleE
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = GetValueFromUser("Введите целое положительное число.");
            N.SquareStars();
            N = GetValueFromUser("Введите длину квадрата. ");
            N.ОrderNum();
        }

        private static int GetValueFromUser(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
