using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramlamaOdev3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x= 0, y= 0;
            do
            {
                Console.Write($"({x},{y}) ");
                y++;
            } while (y < 2);
            Console.WriteLine();
            x++;
            y = 0;
            do
            {
                Console.Write($"({x},{y}) ");
                y++;
            } while (y < 2);
            Console.ReadLine();
        }
    }
}
