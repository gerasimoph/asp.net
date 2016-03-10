using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numResult = 0;
            Console.WriteLine("Введите число");
            int numFirst = Convert.ToInt32(Console.ReadLine());
            if (numFirst > 1)
            {
                for (int i = numFirst; i >= 1; i--)
                {
                    numResult = numResult + i;
                }
            }
            if (numFirst < 1)
            {
                while (numFirst <= 1)
                {
                    numResult = numResult + numFirst;
                    numFirst++;
                }
            }
            Console.WriteLine("Сумма чисел до 1 есть {0}", numResult);
        }
    }
}
