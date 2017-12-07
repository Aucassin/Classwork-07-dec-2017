using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            for (int i = 40; i < 256; i++)
            {
                Console.Write($"{i,3} - {(char)i}   ");
                counter++;
                if (counter == 10)
                {
                    Console.WriteLine();
                    counter = 1;
                }
            }

        }
    }
}
