using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
                for (int i = a; i <= b; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            else if (a % 2 != 0)
                for (int i = a + 1; i <= b; i = i + 2)
                {
                    Console.WriteLine(i);
                }

        }
    }
}
