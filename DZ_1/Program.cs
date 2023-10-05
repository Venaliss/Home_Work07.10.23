using System;

namespace DZ_1
{
    class Program
    {   /*5.1 Тумаков - Создать метод который возвращает максимальное из двух значений*/
        static long Max(long Number1, long Number2 )
        {
            return Number1 > Number2 ? Number1 : Number2;
        }

        /*5.2 Тумаков - Создать метод который меняет числа местами*/
        static void Swap(ref double Num1, ref double Num2, double Num3)
        {
            Num3 = Num2;
            Num2 = Num1;
            Num1 = Num3;
        }

        /*Упражнение 5.3 Тумаков - Создать метод вычисления факториала числа, используя (Checked), выводит True or False*/
        public static bool Factorial(int count, out long fact)
        {
            fact = 1;
            try
            {
                checked
                {
                    for (int i = 2; i <= count; i++)
                    {
                        fact *= i;
                    }
                }
                return true;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        /*Упражнение 5.4 Тумаков - Написать рекурсивный метод вычисления факториала числа*/
        public static int FactorialReck(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * FactorialReck(n - 1);
            }
        }


        static void Main(string[] args)
        {
            /*5.1 Тумаков - Создать метод который возвращает максимальное из двух значений*/
        Console.WriteLine("Упражнение 5.1 Тумаков - Создать метод который возвращает максимальное из двух введеных чисел");
            Console.WriteLine("Введите два числовых значения:");
            if (Int64.TryParse(Console.ReadLine(), out long Number1) && Int64.TryParse(Console.ReadLine(), out long Number2))
            {
                Console.WriteLine($"Ваше максимальное число:{Max(Number1, Number2)}");
            }
            else
            {
                Console.WriteLine("Неправильный формат данных. Введите числовое значение.");
            }


            /*5.2 Тумаков - Создать метод который меняет числа местами*/
            Console.WriteLine("\nУпражнение 5.2 Тумаков - Создать метод который меняет числа местами\nВведите два численных значения: ");
            double Num3 = 0;
            if (double.TryParse(Console.ReadLine(), out double Num1) && double.TryParse(Console.ReadLine(), out double Num2))
            {
                Console.WriteLine($"Ваш запрос: {Num1}, {Num2}");
                Swap(ref Num1, ref Num2, Num3);
                Console.WriteLine($"Ваш результат: {Num1}, {Num2}\n");
            }
            else
            {
                Console.WriteLine("Ошибка введения данных. Введите 2 числовых значения!\n");
            }


            /*Упражнение 5.3 Тумаков - Создать метод вычисления факториала числа, используя (Checked)*/
            Console.WriteLine("\nУпражнение 5.3 Тумаков - Создать метод вычисления факториала числа, используя (Checked)\nВведите число, факториал которого нужно вычислить:");
            if (int.TryParse(Console.ReadLine(), out int count))
            {
                if (Factorial(count, out long fact))
                {
                    Console.WriteLine($"Факториал числа {count} равен {fact}");
                }
            }
            else
            {
                Console.WriteLine("Не удалось вычислить факториал числа");
            }


            /*Упражнение 5.4 Тумаков - Написать рекурсивный метод вычисления факториала числа*/
            Console.WriteLine("\nУпражнение 5.4 Тумаков - Написать рекурсивный метод вычисления факториала числа\nВведите число, факториал которого нужно вычислить:\n");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine($"Факториал числа равен {FactorialReck(num)}");
            }
            else
            {
                Console.WriteLine("Ошибка ввода числового значения.");
            }
            Console.ReadKey();
        }
    }
}
