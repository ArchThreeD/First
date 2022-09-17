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
            Random random = new Random();
            int minValue = 0;
            int maxValue = 101;
            int number = random.Next(minValue, maxValue);
            int sum = 0;
            int firstMultiplicityNumber = 3;
            int secondMultiplicityNumber = 5;
            
            for (int i = 0; i <= number; i++)
            {
                if (i % firstMultiplicityNumber == 0 || i % secondMultiplicityNumber == 0)
                {
                    sum+=i;
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
