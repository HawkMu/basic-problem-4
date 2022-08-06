using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 解答を参考
            int evenCount = 0;
            int oddCount = 0;

            Random rnd = new Random();
            {
                for (int i = 1; i <= 5; i++)
                {
                    int a = rnd.Next(1, 101);
                    Console.WriteLine(a);
                    if (a % 2 == 0)
                    {
                        evenCount++;
                    }
                    else
                    {
                        oddCount++;
                    }
                }
                Console.WriteLine("偶数は:" + evenCount);
                Console.WriteLine("奇数は:" + oddCount);
            }
        }
    }
}
