using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //解答を参考
            Random random = new Random();
            
            for(int i = 1; i<= 1; i++)
            {
                int dise = random.Next(1, 11);

                for(int a = 1; a <= dise; a++)
                {
                    if(dise % 2 == 0)
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
