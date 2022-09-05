using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ammountOfFrames = 10;

            for (int i = 0; i < ammountOfFrames; i++)
            {
                Console.WriteLine("hello");
                Thread.Sleep(500);
            }
        }
    }
}
