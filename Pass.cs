using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "qwer";
            bool passTry = false;
            string userInput;
            int maxAttempts = 3;
            while (maxAttempts-->0 &! passTry==true)
            {
                Console.Write("Введите пароль, для доступа к информации: ");
                userInput = Console.ReadLine();
                if (userInput == password)
                {
                    ConsoleColor defaultColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Нужная вам вещь находится в правом ящике. Код (ЯРКОЕ СОЛНЦЕ)");
                    Console.ForegroundColor = defaultColor;
                    passTry = true;
                }
                else
                {
                    Console.WriteLine("Пробуйте снова");
                }
            }
            if (maxAttempts < 0)
            {
                ConsoleColor defaultColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("У вас больше не осталось попыток!!...");
                Console.ForegroundColor = defaultColor;
            }
        }
    }
}
