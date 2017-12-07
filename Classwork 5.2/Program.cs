using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine(a);
                a++;
            }
            for (int i = 255; i > 0; i = i - 1)
            {
                Console.WriteLine(i);
            }

        }
    }
}
