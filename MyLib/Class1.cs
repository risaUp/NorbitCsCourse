using System;

namespace ClassLibrary
{
    ///<summary>
    ///вычисления на основе заданых значений
    ///</summary>
    public static class StringLibrary
    {
        ///<summary>
        ///Вывод квадрата звёзд с пустым центром
        ///</summary>
        public static void SquareStars(this int N)
        {

            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= N; i++)
                {
                    if ((i == j) && (i == (N / 2))) {
                        Console.Write(" ");
                    }
                    else

                        Console.Write("*");
                }
            }
        }

        public static void ОrderNum(this int N)
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

