using System;

namespace DZ_2
{
    class Program
    {
        /*"Задание 1 - вывести на экран массив, а потом поменять местами 2 его элементов"*/
        static void ShowArray(params int[] array)/* Показ массива до изменений*/
        {
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }

        public static bool swap(int x, int y, ref int[] array) /*Смена двух элементов массива по индексам*/
        {
            if (array.Length <= y || array.Length <= x)
            {
                return false;
            }
            else
            {
                var temp = array[x];
                array[x] = array[y];
                array[y] = temp;
                return true;
            }       
        }
        static void Main(string[] args)
        {
            /*"Задание 1 - вывести на экран массив, а потом поменять местами 2 его элементов"*/
            Console.WriteLine("Задание 1 - вывести на экран массив, а потом поменять местами 2 его элементов\n");
            Random rnd = new Random();
            int[] arr = new int[20];
            for (int i = 0; i < 20; i++)
            {
                arr[i] = rnd.Next();/*Добавляем в массив рандомные числа*/
            }
            ShowArray(arr);
            Console.WriteLine("\n\nВведите два индекса массива от 0 до 19:");
            if (int.TryParse(Console.ReadLine(), out int x) && int.TryParse(Console.ReadLine(), out int y))
            {
                if (swap(x, y, ref arr))
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write("{0} ", arr[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода. Введено число, за пределом массива");
                }

            }
            else
            {
                Console.WriteLine("Ошибка ввода. Неверное значение для данного типа.");
            }

            Console.ReadKey();

        }
    }
}
