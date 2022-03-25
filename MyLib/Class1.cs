using System;

namespace MyLib
{
    public static class StringLibrary
    {
        /// <summary>
        /// На основании принятых от пользователя данных производит вычисления.
        /// </summary>
        public static void SquareStars(this int N)
        {
            /// <summary>
            /// Вывод квадрата из звёзд.
            /// </summary>
            int center = N / 2;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(
                        (i == center && j == center)
                         ? "   "
                         : " * ");
                }
            }
        }
        public static void OrderNum(this int N)
        {

            /// <summary>
            /// вывод перечесления цифр через запятую.
            /// </summary>
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
