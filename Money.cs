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
            const string FirstCase = "1";
            const string SecondCase = "2";
            const string ThirdCase = "3";
            const string FourthCase = "4";
            const string FifthCase = "5";
            const string SixthCase = "6";
            double ConvertRubToUsdCommand = 61.45;
            double ConvertRubToKztCommand = 0.13;
            double ConvertKztToUsdCommand = 472.25;
            double ConvertUsdToRubCommand = 0.01627;
            double ConvertKztToRubCommand = 7.69230;
            double ConvertUsdToKztCommand = 0.00211;
            double amountOfMoneyInRub;
            double amountOfMoneyInUsd;
            double amountOfMoneyInKzt;
            string userInput;
            double amountOfMoney;
            double remainderOfMoney;
            Console.WriteLine("Здравствуйте, у нас вы можете обменять доллары , рубли и тенге.");
            Console.WriteLine("В какую валюту вы хотите конвертировать?: ");
            Console.WriteLine("1 - обменять рубли на доллары");
            Console.WriteLine("2 - обменять рубли на тенге");
            Console.WriteLine("3 - обменять доллары на рубли");
            Console.WriteLine("4 - обменять доллары на тенге");
            Console.WriteLine("5 - обменять тенге на доллары");
            Console.WriteLine("6 - обменять тенге на рубли");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                    
                    case FirstCase:
                        Console.WriteLine("Обмен рублей на доллары");
                        Console.Write("Сколько у вас рублей?: ");
                        amountOfMoneyInRub = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Сколько вы хотите обменять");
                        amountOfMoney = Convert.ToDouble(Console.ReadLine());

                        if (amountOfMoneyInRub >= amountOfMoney)
                        {
                            amountOfMoneyInUsd = amountOfMoney * ConvertUsdToRubCommand;
                            remainderOfMoney = amountOfMoneyInRub - amountOfMoney;
                            Console.WriteLine($"Вы получили {amountOfMoneyInUsd} долларов и у вас осталось {remainderOfMoney} рублей");
                        }
                        else if (amountOfMoneyInRub < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;

                    case SecondCase:
                        Console.WriteLine("Обмен рублей на тенге");
                        Console.Write("Сколько у вас рублей?: ");
                        amountOfMoneyInRub = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести рублей в тенге?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());

                        if (amountOfMoneyInRub >= amountOfMoney)
                        {
                            amountOfMoneyInKzt = amountOfMoney * ConvertKztToRubCommand;
                            remainderOfMoney = amountOfMoneyInRub - amountOfMoney;
                            Console.WriteLine($"Вы получили {amountOfMoneyInKzt} тенге и у вас осталось {remainderOfMoney} рублей");
                        }
                        else if (amountOfMoneyInRub < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;

                    case ThirdCase:
                        Console.WriteLine("Обмен долларов на рубли");
                        Console.Write("Сколько у вас долларов?: ");
                        amountOfMoneyInUsd = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести долларов в рубли?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());

                        if (amountOfMoneyInUsd >= amountOfMoney)
                        {
                            amountOfMoneyInRub = amountOfMoney * ConvertRubToUsdCommand;
                            remainderOfMoney = amountOfMoneyInUsd - amountOfMoney;
                            Console.WriteLine($"Вы получили {amountOfMoneyInRub} рублей и у вас осталось {remainderOfMoney} долларов");
                        }
                        else if (amountOfMoneyInUsd < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;

                    case FourthCase:
                        Console.WriteLine("Обмен долларов на тенге");
                        Console.Write("Сколько у вас долларов?: ");
                        amountOfMoneyInUsd = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести долларов в тенге?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());

                        if (amountOfMoneyInUsd >= amountOfMoney)
                        {
                            amountOfMoneyInKzt = amountOfMoney * ConvertKztToUsdCommand;
                            remainderOfMoney = amountOfMoneyInUsd - amountOfMoney;
                            Console.WriteLine($"Вы получили {amountOfMoneyInKzt} тенге и у вас осталось {remainderOfMoney} долларов");
                        }
                        else if (amountOfMoneyInUsd < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;

                    case FifthCase:
                        Console.WriteLine("Обмен тенге на доллары");
                        Console.Write("Сколько у вас тенге?: ");
                        amountOfMoneyInKzt = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести тенге в доллары?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());

                        if (amountOfMoneyInKzt >= amountOfMoney)
                        {
                            amountOfMoneyInUsd = amountOfMoney * ConvertUsdToKztCommand;
                            remainderOfMoney = amountOfMoneyInKzt - amountOfMoney;
                            Console.WriteLine($"Вы получили {amountOfMoneyInUsd} долларов и у вас осталось {remainderOfMoney} тенге");
                        }
                        else if (amountOfMoneyInKzt < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;

                    case SixthCase:
                        Console.WriteLine("Обмен тенге на рубли");
                        Console.Write("Сколько у вас тенге?: ");
                        amountOfMoneyInKzt = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести тенге в рубли?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());

                        if (amountOfMoneyInKzt >= amountOfMoney)
                        {
                            amountOfMoneyInRub = amountOfMoney * ConvertRubToKztCommand;
                            remainderOfMoney = amountOfMoneyInKzt - amountOfMoney;
                            Console.WriteLine($"Вы получили {amountOfMoneyInRub} рублей и у вас осталось {remainderOfMoney} тенге");
                        }
                        else if (amountOfMoneyInKzt < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;
                    
                    default:
                        Console.WriteLine("Повторите попытку еще раз");
                        break;
            }
        }
    }
}
