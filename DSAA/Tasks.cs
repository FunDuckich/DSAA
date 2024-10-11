using System;
using System.Collections.Generic;

namespace DSAA
{
    public class Tasks
    {
        #region Пр2, II 1

        public static void Pr2Ii1()
        {
            Console.Write("Введите число: ");
            double num = double.Parse(Console.ReadLine());
            Console.Write(num % 2 == 0 ? "Число чётное" : "Число нечётное");
        }

        #endregion

        #region Пр3, IV 1

        public static void Pr3Iv1()
        {
            Console.Write("Введите число A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B >= A: ");
            int b = int.Parse(Console.ReadLine());

            // Именно цикл for, т.к. с ним проще работать при известных границах
            for (int num = b; num >= a; num--)
            {
                Console.Write(num * num + " ");
            }
        }

        #endregion

        #region Пр5, II 8

        private static int AmountOfOddDigits(int n)
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

        public static void Pr5Ii8A()
        {
            Console.Write("Введите число A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = int.Parse(Console.ReadLine());

            for (int num = a; num <= b; num++)
            {
                Console.WriteLine($"{num} - {AmountOfOddDigits(num)}");
            }
        }

        public static void Pr5Ii8B()
        {
            Console.Write("Введите число A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = int.Parse(Console.ReadLine());

            for (int num = a % 2 == 0 ? a : a + 1; num <= b; num += 2)
            {
                if (AmountOfOddDigits(num) == 0)
                {
                    Console.Write(num + " ");
                }
            }
        }

        public static void Pr5Ii8C()
        {
            Console.Write("Введите число A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = int.Parse(Console.ReadLine());

            int maxAmountOfOddDigits = int.MinValue;
            for (int i = a % 2 != 0 ? a : a + 1; i <= b; i += 2)
            {
                int currentAmount = AmountOfOddDigits(i);
                maxAmountOfOddDigits = currentAmount > maxAmountOfOddDigits ? currentAmount : maxAmountOfOddDigits;
            }

            for (int i = a % 2 != 0 ? a : a + 1; i <= b; i += 2)
            {
                if (AmountOfOddDigits(i) == maxAmountOfOddDigits)
                {
                    Console.Write(i + " ");
                }
            }
        }

        public static void Pr5Ii8D()
        {
            Console.Write("Введите число A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = int.Parse(Console.ReadLine());
            int number = a;
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
            }
        }

        #endregion

        #region Пр5, III 7

        public static void Pr5Iii7()
        {
            double SmthInteresting(double x, int n)
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

            Console.WriteLine(SmthInteresting(xX, nN));
        }

        #endregion

        #region Пр5, IV 7

        public static void Pr5Iv7()
        {
            void NumberReverser(int num)
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
            }
        }

        #endregion

        #region Пр7, IV 1

        public static void Pr7Iv1()
        {
            Console.Write("Введите целое число n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int[] ans = new int[n];
            Console.WriteLine("Введите массив из целых чисел, разделённый пробелами, рамером n, n:");
            for (int i = 0; i < n; i++)
            {
                string[] stroke = Console.ReadLine().Split();
                ans[i] = int.MinValue;

                for (int j = 0; j < n; j++)
                {
                    int num = int.Parse(stroke[j]);
                    ans[i] = num > ans[i] ? num : ans[i];
                }
            }

            foreach (int val in ans)
            {
                Console.Write(val);
                Console.Write(" ");
            }
        }

        #endregion

        #region Пр7, VI 6

        public static void Pr7Vi6()
        {
            Console.Write("Введите целое число n: ");
            int n = int.Parse(Console.ReadLine());
            int m = n;
            Console.WriteLine("");
            Console.WriteLine("Введите массив из целых чисел, разделённый пробелами, рамером n, n:");
            int[][] massive = new int[n][];
            HashSet<int> strokesForDeleting = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                massive[i] = new int[m];
                bool noEvenInStoke = true;
                string[] stroke = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    massive[i][j] = int.Parse(stroke[j]);
                    if (massive[i][j] % 2 == 0)
                    {
                        noEvenInStoke = false;
                    }
                }

                if (noEvenInStoke)
                {
                    strokesForDeleting.Add(i);
                }
            }

            foreach (int stokeForDeleting in strokesForDeleting)
            {
                for (int i = stokeForDeleting; i < n - 1; i++)
                {
                    massive[i] = massive[i + 1];
                }

                n--;
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                foreach (int num in massive[i])
                {
                    Console.Write(num + " ");
                }

                Console.WriteLine();
            }
        }

        #endregion
    }
}