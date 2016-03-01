using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elections
{
    class Program
    {
        static void Main(string[] args)
        {
            int half = 0;
            int sum = 0;
            Console.WriteLine("Введите количество групп избирателей:");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num >= 100 || num <= 1 || num%2==0)
            {
                Console.WriteLine("Введите нечетное число в диапазоне [1;101]:");
                num = 0;
                num = Convert.ToInt32(Console.ReadLine());
            }
            int[] arr = new int[num];
            // Забиваем массив
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Сколько избирателей в группе №{0}?", i + 1);
                int a = Convert.ToInt32(Console.ReadLine());
                while (a % 2 == 0)
                {
                    a = 0;
                    Console.WriteLine("Введите нечетное число избирателей:");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                arr[i] = a;
            }
            Array.Sort(arr); // сортируем по возрастанию
            half = arr.Length / 2 + 1; //сколько необходимо групп для победы
            for (int k = 0; k < half; k++)
            {
                sum = arr[k] / 2 + 1 + sum;
            }
            Console.WriteLine("\nДля победы на выборах необходимо {0} избирателей и {1} группы.", sum, half);
        }
    }
}
