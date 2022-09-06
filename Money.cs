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
            double rubToUsd = 61.45;
            double rubToKzt = 0.13;
            double kztToUsd = 472.25;
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
            try
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Обмен рублей на доллары");
                        Console.Write("Сколько у вас рублей?: ");
                        amountOfMoneyInRub = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Сколько вы хотите обменять");
                        amountOfMoney = Convert.ToDouble(Console.ReadLine());
                        if (amountOfMoneyInRub >= amountOfMoney)
                        {
                            amountOfMoneyInUsd = amountOfMoney / rubToUsd;
                            remainderOfMoney = amountOfMoneyInRub - amountOfMoney;
                            Console.WriteLine($"Вы получили {amountOfMoneyInUsd} долларов и у вас осталось {remainderOfMoney} рублей");
                        }
                        else if (amountOfMoneyInRub < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Обмен рублей на тенге");
                        Console.Write("Сколько у вас рублей?: ");
                        amountOfMoneyInRub = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести рублей в тенге?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());
                        if (amountOfMoneyInRub >= amountOfMoney)
                        {
                            amountOfMoneyInKzt = amountOfMoney / rubToKzt;
                            remainderOfMoney = amountOfMoneyInRub - amountOfMoney;
                            Console.WriteLine($"Вы получили {amountOfMoneyInKzt} тенге и у вас осталось {remainderOfMoney} рублей");
                        }
                        else if (amountOfMoneyInRub < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Обмен долларов на рубли");
                        Console.Write("Сколько у вас долларов?: ");
                        amountOfMoneyInUsd = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести долларов в рубли?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());
                        if (amountOfMoneyInUsd >= amountOfMoney)
                        {
                            amountOfMoneyInRub = amountOfMoney * rubToUsd;
                            remainderOfMoney = amountOfMoneyInUsd - amountOfMoney;
                            Console.WriteLine($"Вы получили {amountOfMoneyInRub} рублей и у вас осталось {remainderOfMoney} долларов");
                        }
                        else if (amountOfMoneyInUsd < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Обмен долларов на тенге");
                        Console.Write("Сколько у вас долларов?: ");
                        amountOfMoneyInUsd = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести долларов в тенге?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());
                        if (amountOfMoneyInUsd >= amountOfMoney)
                        {
                            amountOfMoneyInKzt = amountOfMoney * kztToUsd;
                            remainderOfMoney = amountOfMoneyInUsd - amountOfMoney;
                            Console.WriteLine($"Вы получили {amountOfMoneyInKzt} тенге и у вас осталось {remainderOfMoney} долларов");
                        }
                        else if (amountOfMoneyInUsd < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Обмен тенге на доллары");
                        Console.Write("Сколько у вас тенге?: ");
                        amountOfMoneyInKzt = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести тенге в доллары?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());
                        if (amountOfMoneyInKzt >= amountOfMoney)
                        {
                            amountOfMoneyInUsd = amountOfMoney / kztToUsd;
                            remainderOfMoney = amountOfMoneyInKzt - amountOfMoney;
                            Console.WriteLine($"Вы получили {amountOfMoneyInUsd} долларов и у вас осталось {remainderOfMoney} тенге");
                        }
                        else if (amountOfMoneyInKzt < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;
                    case "6":
                        Console.WriteLine("Обмен тенге на рубли");
                        Console.Write("Сколько у вас тенге?: ");
                        amountOfMoneyInKzt = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести тенге в рубли?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());
                        if (amountOfMoneyInKzt >= amountOfMoney)
                        {
                            amountOfMoneyInRub = amountOfMoney * rubToKzt;
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
            catch            
            {         
            Console.WriteLine("Ошибка при вводе данных.");    
            }         
        }
    }
}
