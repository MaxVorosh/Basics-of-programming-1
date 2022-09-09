namespace Task3
{
    public class Task3
    {
/*
 * Прежде чем приступать к выполнению заданий, допишите к ним тесты.
 */

/*
 * Задание 3.1. Для данного вещественного x найти значение следующей функции f, принимающей значения целого типа:
 * 	        0,	если x < 0,
 * f(x) = 	1,	если x принадлежит [0, 1), [2, 3), …,
           −1,	если x принадлежит [1, 2), [3, 4), … .
 */
        internal static double F(double x) => (x < 0) ? 0: ((Math.Floor(x) % 2 == 0) ? 1: -1);

/*
 * Задание 3.2. Дан номер года (положительное целое число). Определить количество дней в этом году,
 * учитывая, что обычный год насчитывает 365 дней, а високосный — 366 дней. Високосным считается год,
 * делящийся на 4, за исключением тех годов, которые делятся на 100 и не делятся на 400
 * (например, годы 300, 1300 и 1900 не являются високосными, а 1200 и 2000 — являются).
 */
        internal static int NumberOfDays(int year)
        {
            if (year % 4 != 0)
            {
                return 365;
            }

            if (year % 100 == 0 && year % 400 != 0)
            {
                return 365;
            }

            return 366;
        }
        //return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) ? 366 : 365;
        

        /*
 * Задание 3.3. Локатор ориентирован на одну из сторон света («С» — север, «З» — запад,
 * «Ю» — юг, «В» — восток) и может принимать три цифровые команды поворота:
 * 1 — поворот налево, −1 — поворот направо, 2 — поворот на 180°.
 * Дан символ C — исходная ориентация локатора и целые числа N1 и N2 — две посланные команды.
 * Вернуть ориентацию локатора после выполнения этих команд.
 */
        internal static char Rotate2(char orientation, int cmd1, int cmd2)
        {
            char rotate1(char orientation, int cmd) 
            {
                string sides = "СЗЮВСЗЮВ";
                int cnt = 4;
                if (orientation == 'В') {
                    cnt = 3;
                }
                else if (orientation == 'Ю') {
                    cnt = 2;
                }
                else if (orientation == 'З')
                {
                    cnt = 1;
                }
                return sides[cnt + cmd];
            }

            return rotate1(rotate1(orientation, cmd1), cmd2);
        }

/*
 * Задание 3.4. Дано целое число в диапазоне 20–69, определяющее возраст (в годах).
 * Вернуть строку-описание указанного возраста, обеспечив правильное согласование
 * числа со словом «год», например: 20 — «двадцать лет», 32 — «тридцать два года»,
 * 41 — «сорок один год».
 *
 * Пожалуйста, научитесь делать такие вещи очень аккуратно. Программное обеспечение
 * переполнено некорректными с точки зрения русского языка решениями.
 */
        internal static String AgeDescription(int age)
        {
            string rezult = "";
            int first_digit = age / 10;
            int second_digit = age % 10;
            if (first_digit == 2)
            {
                rezult = "двадцать ";
            }
            else if (first_digit == 3) {
                rezult = "тридцать ";
            }
            else if (first_digit == 4)
            {
                rezult = "сорок ";
            }
            else if (first_digit == 5)
            {
                rezult = "пятьдесят ";
            }
            else if (first_digit == 6)
            {
                rezult = "шестьдесят ";
            }
            if (second_digit == 0) {
                rezult += "лет";
            }
            else if (second_digit == 1)
            {
                rezult += "один год";
            }
            else if (second_digit == 2)
            {
                rezult += "два года";
            }
            else if (second_digit == 3)
            {
                rezult += "три года";
            }
            else if (second_digit == 4)
            {
                rezult += "четыре года";
            }
            else if (second_digit == 5)
            {
                rezult += "пять лет";
            }
            else if (second_digit == 6)
            {
                rezult += "шесть лет";
            }
            else if (second_digit == 7)
            {
                rezult += "семь лет";
            }
            else if (second_digit == 8)
            {
                rezult += "восемь лет";
            }
            else if (second_digit == 9)
            {
                rezult += "девять лет";
            }
            return rezult;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(F(3.4));
            Console.WriteLine(NumberOfDays(234));
            Console.WriteLine(Rotate2('С', -1, 1));
            Console.WriteLine(AgeDescription(34));
        }
    }
}