using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for(int i = 1; i <= num; i++)
            {
                Console.Write("■");
            }
            Console.WriteLine();
        }
    }
}
