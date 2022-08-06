using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 解答を参考
            for(int i = 9; i >= 0; i--)
            {
               for(int j = 10; j >= 0; j--)
                    if(i < j)
                    {
                        Console.WriteLine("■");
                    }else
                    {
                        Console.WriteLine("□");
                    }
                Console.WriteLine();
            }
        }
    }
}
