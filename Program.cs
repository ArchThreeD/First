using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            char symbol;
            string lineWidth = "";

            Console.Write("Введите свое имя: ");
            name = Console.ReadLine();
            Console.Write("Введите символ: ");
            symbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Ваше имя {name} . Длина вашего имени {name.Length}");
            for (int i = 0; i < name.Length; i++)
            {
                lineWidth += symbol;         
            }
            Console.WriteLine($"{symbol}{lineWidth}{symbol}\n{symbol}{name}{symbol}\n{symbol}{lineWidth}{symbol}");
        }
    }
}
