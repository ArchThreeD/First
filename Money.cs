using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ExecutingTheFirstCommand = "1";
            const string ExecutingTheSecondCommand = "2";
            const string ExecutingTheThirdCommand = "3";
            const string ExecutingTheFourthCommand = "4";
            const string ExecutingTheFifthCommand = "5";
            const string ExecutingTheSixthCommand = "6";
            const string ExecutingTheSevenCommand = "7";
            double ConvertRubToUsd = 61.45;
            double ConvertRubToKzt = 0.13;
            double ConvertKztToUsd = 472.25;
            double ConvertUsdToRub = 0.01627;
            double ConvertKztToRub = 7.69230;
            double ConvertUsdToKzt = 0.00211;
            double amountOfMoneyInRub;
            double amountOfMoneyInUsd;
            double amountOfMoneyInKzt;
            string userInput;
            double amountOfMoney;
            double remainderOfMoney;
            bool close = true;
            Console.WriteLine("Здравствуйте, у нас вы можете обменять доллары , рубли и тенге.");

            while (close)
            {
                Console.WriteLine("В какую валюту вы хотите конвертировать?: ");
                Console.WriteLine("1 - обменять рубли на доллары");
                Console.WriteLine("2 - обменять рубли на тенге");
                Console.WriteLine("3 - обменять доллары на рубли");
                Console.WriteLine("4 - обменять доллары на тенге");
                Console.WriteLine("5 - обменять тенге на доллары");
                Console.WriteLine("6 - обменять тенге на рубли");
                Console.WriteLine("7 - выход из программы");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case ExecutingTheFirstCommand:
                        Console.WriteLine("Обмен рублей на доллары");
                        Console.Write("Сколько у вас рублей?: ");
                        amountOfMoneyInRub = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Сколько вы хотите обменять");
                        amountOfMoney = Convert.ToDouble(Console.ReadLine());

                        if (amountOfMoneyInRub >= amountOfMoney)
                        {
                            amountOfMoneyInUsd = amountOfMoney * ConvertUsdToRub;
                            remainderOfMoney = amountOfMoneyInRub - amountOfMoney;
                            Console.WriteLine($"Вы получили {amountOfMoneyInUsd} долларов и у вас осталось {remainderOfMoney} рублей");
                        }
                        else if (amountOfMoneyInRub < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;

                    case ExecutingTheSecondCommand:
                        Console.WriteLine("Обмен рублей на тенге");
                        Console.Write("Сколько у вас рублей?: ");
                        amountOfMoneyInRub = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести рублей в тенге?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());

                        if (amountOfMoneyInRub >= amountOfMoney)
                        {
                            amountOfMoneyInKzt = amountOfMoney * ConvertKztToRub;
                            remainderOfMoney = amountOfMoneyInRub - amountOfMoney;
                            Console.WriteLine($"Вы получили {amountOfMoneyInKzt} тенге и у вас осталось {remainderOfMoney} рублей");
                        }
                        else if (amountOfMoneyInRub < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;

                    case ExecutingTheThirdCommand:
                        Console.WriteLine("Обмен долларов на рубли");
                        Console.Write("Сколько у вас долларов?: ");
                        amountOfMoneyInUsd = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести долларов в рубли?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());

                        if (amountOfMoneyInUsd >= amountOfMoney)
                        {
                            amountOfMoneyInRub = amountOfMoney * ConvertRubToUsd;
                            remainderOfMoney = amountOfMoneyInUsd - amountOfMoney;
                            Console.WriteLine($"Вы получили {amountOfMoneyInRub} рублей и у вас осталось {remainderOfMoney} долларов");
                        }
                        else if (amountOfMoneyInUsd < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;

                    case ExecutingTheFourthCommand:
                        Console.WriteLine("Обмен долларов на тенге");
                        Console.Write("Сколько у вас долларов?: ");
                        amountOfMoneyInUsd = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести долларов в тенге?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());

                        if (amountOfMoneyInUsd >= amountOfMoney)
                        {
                            amountOfMoneyInKzt = amountOfMoney * ConvertKztToUsd;
                            remainderOfMoney = amountOfMoneyInUsd - amountOfMoney;
                            Console.WriteLine($"Вы получили {amountOfMoneyInKzt} тенге и у вас осталось {remainderOfMoney} долларов");
                        }
                        else if (amountOfMoneyInUsd < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;

                    case ExecutingTheFifthCommand:
                        Console.WriteLine("Обмен тенге на доллары");
                        Console.Write("Сколько у вас тенге?: ");
                        amountOfMoneyInKzt = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести тенге в доллары?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());

                        if (amountOfMoneyInKzt >= amountOfMoney)
                        {
                            amountOfMoneyInUsd = amountOfMoney * ConvertUsdToKzt;
                            remainderOfMoney = amountOfMoneyInKzt - amountOfMoney;
                            Console.WriteLine($"Вы получили {amountOfMoneyInUsd} долларов и у вас осталось {remainderOfMoney} тенге");
                        }
                        else if (amountOfMoneyInKzt < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;

                    case ExecutingTheSixthCommand:
                        Console.WriteLine("Обмен тенге на рубли");
                        Console.Write("Сколько у вас тенге?: ");
                        amountOfMoneyInKzt = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести тенге в рубли?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());

                        if (amountOfMoneyInKzt >= amountOfMoney)
                        {
                            amountOfMoneyInRub = amountOfMoney * ConvertRubToKzt;
                            remainderOfMoney = amountOfMoneyInKzt - amountOfMoney;
                            Console.WriteLine($"Вы получили {amountOfMoneyInRub} рублей и у вас осталось {remainderOfMoney} тенге");
                        }
                        else if (amountOfMoneyInKzt < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;

                    case ExecutingTheSevenCommand:
                        {
                            close = false;
                            ConsoleColor defaultColor = Console.ForegroundColor;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Всего хорошего, ждем вас снова:");
                            Console.ForegroundColor = defaultColor;
                            break;
                        }
                }
            }
        }
    }
}
