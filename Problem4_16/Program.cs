using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 解答を参考
            for(int a = 1; a <= 9; a++)
            {
                for(int b = 1; b <= 9; b++)
                {
                    int c = a * b;
                    Console.Write(a + "*" + b + "=" + c + " ");
                }
            }
        }
    }
}
