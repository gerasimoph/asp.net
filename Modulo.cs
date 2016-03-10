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
            int buff = 1;
            int k = 5;
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num>99999||num<10000)
            {
                Console.WriteLine("Введите пятизначное число:");
                num = Convert.ToInt32(Console.ReadLine());
            }
            for (int i=0; i < 5; i++)
            {
                Console.WriteLine("{0} место занимает цифра {1}", k--, (num / buff) % 10);
                buff = buff * 10;
            }
        }
    }
}
