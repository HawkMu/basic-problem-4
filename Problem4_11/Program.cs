using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 解答を参考
            Random rnd = new Random();
            List<int> rndList = new List<int>();
            for (int i = 1; i <= 5; i++)
            {
                int a = rnd.Next(1, 101);
                Console.WriteLine(a);
                rndList.Add(a);
            }
            int min = rndList.Min();
            int max = rndList.Max();

            Console.WriteLine("最大値:" + max);
            Console.WriteLine("最小値:" + min);
        }
    }
}
