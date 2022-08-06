using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("0以上の数値を入力してください:");
                int num = int.Parse(Console.ReadLine());
                int a = num;
                
                if(a >= 0)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine("終了します");
                    break;
                }
            }
        }
    }
}
