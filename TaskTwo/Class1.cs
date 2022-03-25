using System;

namespace FuncLib
{
    public class Class1
    {
        /// <summary>
        /// рассчитывает индекс массы тела человека.
        /// </summary>
        /// <param name="mass"> вес человека</param>
        /// <param name="body"> рост человека в метрах через запятую</param>
        /// <returns></returns>
        public static double IndexMassBody(double mass, double body)
        {
            return Math.Round(mass / Math.Pow(body, 2), 1);
            
        }

        /// <summary>
        /// заполнение массива рандомными значениями и их сортировка.
        /// </summary>
        /// <returns></returns>
        public static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }

        /// <summary>
        /// Получает строку от пользователя, убирает лишние символы и возвращает среднее значение длины слов в строке.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static double AverageTextLength(string str)
        {
            Char[] arr = str.ToCharArray();
            for (int i = 0; i< arr.Length; i++)
            {
                char a = arr[i];
                if (char.IsPunctuation(a) || char.IsSeparator(a))
                {
                    arr[i] = ' ';
                }
            }
            string resultString = new string(arr);

            double averageValue = 0;
            resultString = string.Join(" ", resultString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            string[] arrayString = resultString.Split(" ");
            for (int i = 0; i < arrayString.Length; i++)
            {
                averageValue += arrayString[i].Length;
            }
            return averageValue / arrayString.Length;
            
        }
    }
}