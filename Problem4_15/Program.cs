using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 解答を参考
            for (int i = 1; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(i + " ");
                }
                else
                {
                    Console.Write(i + "");
                }
            }
        }
    }
}
