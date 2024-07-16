using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_fibonacci_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, n1 = 0, n2 = 1, n3;
            Console.WriteLine("Enter the no. of elements");
            number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1 + " \n" +
                "" + n2 + " ");
            for (int i = 1; i < number; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
