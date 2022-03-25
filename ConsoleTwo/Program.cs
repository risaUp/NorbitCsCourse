using System;
using FuncLib;

namespace ConsoleTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteBMI();
            SortArr();
            AverageWordsLrngth();
        }
        public static void WriteBMI()
        {
            Console.WriteLine("Введите свою массу и рост(пишем через запятую)");
            double mass = Convert.ToDouble(Console.ReadLine());
            double body = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Class1.IndexMassBody(mass, body));
        }

        public static void SortArr()
        {
            Console.WriteLine("Сколько чисел будем сортировать?");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Массив до сортировки :");
            int[] mas = new int[N];

            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                mas[i] = rand.Next(1, N);
                Console.WriteLine(mas[i]);
            }
            Class1.BubbleSort(mas);
            Console.WriteLine("После сортировки:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);

            }
            Console.WriteLine("Минимальный элемент массива - " + mas[0]);
            Console.WriteLine("Максимальный элемент массива - " + mas[mas.Length - 1]);

        }

        public static void AverageWordsLrngth()
        {
            Console.WriteLine("Введите строку...");
            Console.WriteLine("Среднее значение длинны слов - " + Class1.AverageTextLength(Console.ReadLine()));
        }


        public static void TestStructLearning()
        {
            Persone persone;
            persone.name = "Святослав";
            persone.age = 19;
            persone.Print();
        }

        struct Persone
        {
            public string name;
            public int age;

            public void Print() => Console.WriteLine($"Имя:{name}, возраст: {age}");


        }
    }
}
