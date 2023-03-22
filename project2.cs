using System;
namespace Task_2 
{
    class QuickSorting
    {
        public static void sort(int[] mas,int first,int last)
        {
            int p = mas[(last – first) / 2 + first];   // ищем средний элемент
            int i = first, j = last;
            while (i <= j) {
                while (mas[i] < p && i <= last) 
                    ++i;
                while (mas[j] > p && j >= first) 
                    --j;
                if (i <= j) {
                    int temp = mas[i];
                    mas[i] = mas[j];
                    mas[j] = temp;
                    ++i; 
                    --j;
                }
            }
            if (j > first) 
                sort(mas, first, j);
            if (i < last) 
                sort(mas, i, last);
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            int n = 100;
            int[] mas = new int[100]; //указываем кол-во элементов массива
            //заполняем массив случайными числами
            Random rand = new Random();
            for (int i = 0; i < n; ++i) {
                mas[i] = rand.Next(1,101);
            }

            Console.WriteLine(“Исходный массив:”);
            for (int i = 0; i < n; i++) {
                Console.Write(mas[i] + “ “);
            }
            //сортировка
            QuickSorting.sort(mas,0,mas.Length – 1);
            Console.WriteLine(«\n\nМассив после сортировки:»);
            for (int i = 0; i < n; i++) {
                Console.Write(mas[i] + “ “);
            }
            Console.WriteLine();
        }
    }
}
