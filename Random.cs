using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(0, 101);
            int sum = 0;
            int firstMultiplicityNumber = 3;
            int secondMultiplicityNumber = 5;

            for (int i = 0; i <= number; i++)
            {

                if (i % firstMultiplicityNumber == 0 || i % secondMultiplicityNumber == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
