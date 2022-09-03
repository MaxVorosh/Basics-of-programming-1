namespace Task4
{
    public class Task4
    {
/*
 * В решениях следующих заданий предполагается использование циклов.
 */

/*
 * Задание 4.1. Пользуясь циклом for, посимвольно напечатайте рамку размера width x height,
 * состоящую из символов frameChar. Можно считать, что width>=2, height>=2.
 * Например, вызов printFrame(5,3,'+') должен напечатать следующее:

+++++
+   +
+++++
 */
        internal static void PrintFrame(int width, int height, char frameChar = '*')
        {
            for (int i = 0; i < height; ++i) {
                for (int j = 0; j < width; ++j) {
                    if (i == 0 || j == 0 || i == height - 1 || j == width - 1) {
                        Console.Write(frameChar);
                    }
                    else { 
                        Console.Write(' ');
                    }
                }
                Console.Write('\n');
            }
        }

/*
 * Задание 4.2. Выполните предыдущее задание, пользуясь циклом while.
 */
        internal static void PrintFrame2(int width, int height, char frameChar = '*')
        {
            int row = 0;
            while (row < height) {
                int column = 0;
                while (column < width) {
                    if (row == 0 || column == 0 || column == width - 1 || row == height - 1) {
                        Console.Write(frameChar);
                    }
                    else {
                        Console.Write(' ');
                    }
                    column++;
                }
                Console.Write('\n');
                row++;
            }
        }


/*
 * Задание 4.3. Даны целые положительные числа A и B. Найти их наибольший общий делитель (НОД),
 * используя алгоритм Евклида:
 * НОД(A, B) = НОД(B, A mod B),    если B ≠ 0;        НОД(A, 0) = A,
 * где «mod» обозначает операцию взятия остатка от деления.
 */
        internal static long Gcd(long a, long b)
        {
            while (b != 0) {
                long c = a % b;
                a = b;
                b = c;
            }
            return a;
        }

/*
 * Задание 4.4. Дано вещественное число X и целое число N (> 0). Найти значение выражения
 * 1 + X + X^2/(2!) + … + X^N/(N!), где N! = 1·2·…·N.
 * Полученное число является приближенным значением функции exp в точке X.
 */
        internal static double ExpTaylor(double x, int n)
        {
            double pow_x = 1;
            double factorial = 1;
            double s = 0;
            for (int i = 1; i <= n; ++i) {
                s += pow_x / factorial;
                pow_x *= x;
                factorial *= i;
            }
            return s;
        }

        public static void Main(string[] args)
        {
            PrintFrame(5, 3, '+');
            PrintFrame2(5, 3, '+');
            Gcd(4, 6);
            ExpTaylor(3, 5);
        }
    }
}