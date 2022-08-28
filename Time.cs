using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timePerPerson = 10;
            int hours;
            int minutes;
            int numberOfPeople;
            int time;
            Console.Write("Какое количество людей перед вами в очереди?: ");
            numberOfPeople = Convert.ToInt32(Console.ReadLine());
            time = timePerPerson * numberOfPeople;
            hours = time / 60; 
            minutes = time % 60;
            Console.WriteLine($"Вам нужно отстоять в очереди {hours} часа и {minutes} минут ");
        }
    }
}
