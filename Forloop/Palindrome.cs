using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloop
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            int num, i, rev;

            Console.WriteLine("enter num");
            num = Convert.ToInt32(Console.ReadLine());

            rev = num;
            for (i = 0; num > 0; num = num / 10)
            {
                i = i * 10;
                i = i + (num % 10);
            }
            if (rev == i)
                Console.WriteLine(rev + "palindrome num");
            else
                Console.WriteLine(rev + "not a palindrome num");
        }
    }
}
