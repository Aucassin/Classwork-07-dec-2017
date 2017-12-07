using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= a; i++)
            {
                sum += i;

            }
            Console.WriteLine(sum);
        }
    }
}
