using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //解答を参考
            Random rnd = new Random();
            for (int i= 0; i < 1; i++)
            {
                int a = rnd.Next(1,11);
                Console.WriteLine("発生した数値:"+a);
                for (int j = 1; j <= a; j++)
                {
                    if(a >= 5)
                    {
                        Console.Write("★");
                    }
                    else
                    {
                        Console.Write("☆");
                    }
                }
            }
        }
    }
}