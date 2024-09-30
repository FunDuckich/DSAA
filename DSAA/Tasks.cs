using System;

namespace DSAA
{
    internal class Tasks
    {
        public static void Main(string[] args)
        {
            #region Пр2, II 1

            // Console.Write("Введите число: ");
            // double num = double.Parse(Console.ReadLine());
            // Console.Write(num % 2 == 0 ? "Число чётное" : "Число нечётное");

            #endregion

            #region Пр3, IV 1

            // Console.Write("Введите число A: ");
            // int a = int.Parse(Console.ReadLine());
            // Console.Write("Введите число B >= A: ");
            // int b = int.Parse(Console.ReadLine());

            // Именно цикл for, т.к. с ним проще работать при известных границах
            // for (int num = b; num >= a; num--)
            // {
            //     Console.Write(num * num + " ");
            // }

            #endregion

            #region Пр5, II 8

            /*int AmountOfOddDigits(int n)
            {
                int num = n;
                int res = 0;
                while (num > 0)
                {
                    res += (num % 10) % 2 != 0 ? 1 : 0;
                    num /= 10;
                }


                return res;
            }

            Console.Write("Введите число A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = int.Parse(Console.ReadLine());*/

            // а)
            // for (int num = a; num <= b; num++)
            // {
            //     Console.WriteLine($"{num} - {AmountOfOddDigits(num)}");
            // }

            // b)
            // for (int num = a % 2 == 0 ? a : a + 1; num <= b; num += 2)
            // {
            //     if (AmountOfOddDigits(num) == 0)
            //     {
            //         Console.Write(num + " ");
            //     }
            // }

            // c)
            /*for (int i = a % 2 != 0 ? a : a + 1; i <= b; i += 2)
            {
                int num = i;
                int amountOfDigits = 0;

                while(num > 0)
                {
                    num /= 10;
                    amountOfDigits++;
                }

                if (AmountOfOddDigits(i) == amountOfDigits)
                {
                    Console.Write(i + " ");
                }
            }*/

            // d)
            /*int number = a;
            int amountOfDigits = 0;

            while (number > 0)
            {
                number /= 10;
                amountOfDigits++;
            }

            if (amountOfDigits >= b)
            {
                while (true)
                {
                    a++;
                    if (AmountOfOddDigits(a) == b)
                    {
                        Console.WriteLine(a);
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < b; i++)
                {
                    Console.Write(1);
                }
            }*/

            #endregion

            #region Пр5, III 7

            /*double SmthInteresting(double x, int n)
            {
                if (n == 0)
                {
                    return 1;
                }

                if (n < 0)
                {
                    return 1 / SmthInteresting(x, Math.Abs(n));
                }

                return x * SmthInteresting(x, n - 1);
            }

            Console.Write("Введите вещественное число x: ");
            double xX = double.Parse(Console.ReadLine());
            Console.Write("Введите целое число n: ");
            int nN = int.Parse(Console.ReadLine());

            Console.WriteLine(SmthInteresting(xX, nN));*/

            #endregion

            #region Пр5, IV 7

            /*void NumberReverser(int num)
            {
                int ost = num % 10;
                int obr = num / 10;
                Console.Write(ost);
                if (obr > 0)
                {
                    NumberReverser(obr);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            
            Console.Write("Введите число A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                NumberReverser(i);
            }*/

            #endregion
        }
    }
}