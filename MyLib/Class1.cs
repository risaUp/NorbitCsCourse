using System;

namespace MyLib
{
    public static class StringLibrary
    {
        public static void WriteStars(this int? N)
        {


            for (int i = 1; i <= N; i++)
            {
                int result = (int)((N + 1) / 2);
                if (i == result)
                {
                    for (int j = 1; j < result; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write(" ");
                    for (int j = 1; j < result; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int j = 1; j <= N; j++)
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\n");
            }
        }

        public static void WriteNum(this int? N)
        {

            for (int i = 1; i <= N; i++)
            {
                if (i == N)
                {
                    Console.Write(i + ".");
                }
                else
                {
                    Console.Write(i + ", ");
                }
            }
        }

    }
}
