using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloop
{
    internal class Armstrong
    {
        static void Main(string[] args)
        {
            int num, sum = 0, i, r;

            Console.WriteLine("enter num");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = num; i > 0; i = i / 10)
            {
                r = i % 10;
                sum = sum + r * r * r;
            }

            if (num == sum)
            {
                Console.WriteLine(num + "is armstrong num");
            }
            else
            {
                Console.WriteLine(num + "is not armstrong num");
            }
        }
    }
}
