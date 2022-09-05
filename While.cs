using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 10;

            while (age-- > 0 )
            {
                Console.WriteLine("Здравствуйте");
                Thread.Sleep(500);
            }
        }
    }
}
