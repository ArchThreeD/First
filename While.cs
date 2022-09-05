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
            int hello = 10;

            while (hello-- > 0 )
            {
                Console.WriteLine("Здравствуйте");
                Thread.Sleep(500);
            }
        }
    }
}
