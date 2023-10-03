using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1
{
    class Program
    {   /*Создать метод который возвращает максимальное из двух значений*/
        static long Max(long Number1, long Number2 )
        {
            return Number1 > Number2 ? Number1 : Number2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 5.1 Тумаков - Создать метод который возвращает максимальное из двух введеных чисел\n");
            Console.WriteLine("Введите два числовых значения:");
            if (Int64.TryParse(Console.ReadLine(), out long Number1) && Int64.TryParse(Console.ReadLine(), out long Number2))
            {
                Console.WriteLine($"Ваше максимальное число:{Max(Number1, Number2)}");
            }
            else
            {
                Console.WriteLine("Неправильный формат данных. Введите числовое значение.");
            }
        }
    }
}
