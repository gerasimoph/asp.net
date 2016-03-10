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
            Console.WriteLine("Сколько банок выбил Гарри?");
            int HarryStrike = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("А Ларри?");
            int LarryStrike = Convert.ToInt32(Console.ReadLine());
            while (HarryStrike+LarryStrike>10 || HarryStrike == 0 || LarryStrike == 0 || HarryStrike < 0 || LarryStrike < 0)
            {
                Console.WriteLine("У них было только 10 банок, как не было ни нуля, ни минус-банок :(");
                Console.WriteLine("Сколько банок выбил Гарри?");
                HarryStrike = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("А Ларри?");
                LarryStrike = Convert.ToInt32(Console.ReadLine());
            }
            int HarryDontStrike = LarryStrike - 1;
            int LarryDontStrike = HarryStrike - 1;
            Console.WriteLine("Гарри не выбил {0} банок, Ларри - {1}", HarryDontStrike, LarryDontStrike);
        }
    }
}
