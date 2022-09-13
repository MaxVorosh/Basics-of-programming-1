using System.Text;

namespace Task2
{
    public class Task2
    {

/*
 * В этих заданиях * рекомендуется всюду использовать класс StringBuilder.
 * Документация: https://docs.microsoft.com/ru-ru/dotnet/api/system.text.stringbuilder?view=net-6.0
 */

/*
 * Задание 2.1. Дана непустая строка S и целое число N (> 0). Вернуть строку, содержащую символы
 * строки S, между которыми вставлено по N символов «*» (звездочка).
 */
        internal static string FillWithAsterisks(string s, int n)
        {
            StringBuilder sb = new StringBuilder(Convert.ToString(s[0]));
            for (int i = 1; i < s.Length; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    sb.AppendFormat("*");
                }
                sb.AppendFormat(Convert.ToString(s[i]));
            }
            return Convert.ToString(sb)!;
        }

/*
 * Задание 2.2. Сформировать таблицу квадратов чисел от 1 до заданного числа N.
 * Например, для N=4 должна получиться следующая строка:

1  1
2  4
3  9
4 16

 * Обратите внимание на выравнивание: числа в первом столбце выравниваются по левому краю,
 * а числа во втором -- по правому, причём между числами должен оставаться как минимум один
 * пробел. В решении можно использовать функции Pad*.
 */
        internal static string TabulateSquares(int n)
        {
            int maxLength = Convert.ToString(n).Length;
            int maxSquareLength = Convert.ToString(n * n).Length;
            StringBuilder table = new StringBuilder();
            for (int i = 1; i <= n; ++i)
            {
                string number = Convert.ToString(i);
                string square = Convert.ToString(i * i);
                table.AppendFormat(number.PadRight(maxLength) + ' ' + square.PadLeft(maxSquareLength) + '\n');
            }

            table.Remove(table.Length - 1, 1);
            return Convert.ToString(table)!;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(FillWithAsterisks("abc", 2));
            Console.WriteLine(TabulateSquares(4));
        }
    }
}