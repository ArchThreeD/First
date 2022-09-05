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
            double rubToUsd = 61.45, rubToKzt = 0.13, kztToUsd = 472.25;
            double rub;
            double usd;
            double kzt;
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
                        rub = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Сколько вы хотите обменять");
                        amountOfMoney = Convert.ToDouble(Console.ReadLine());
                        if (rub >= amountOfMoney)
                        {

                            usd = amountOfMoney / rubToUsd;
                            remainderOfMoney = rub - amountOfMoney;
                            Console.WriteLine($"Вы получили {usd} долларов и у вас осталось {remainderOfMoney} рублей");
                        }
                        else if (rub < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }

                        break;
                    case "2":
                        Console.WriteLine("Обмен рублей на тенге");
                        Console.Write("Сколько у вас рублей?: ");
                        rub = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести рублей в тенге?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());
                        if (rub >= amountOfMoney)
                        {
                            kzt = amountOfMoney / rubToKzt;
                            remainderOfMoney = rub - amountOfMoney;
                            Console.WriteLine($"Вы получили {kzt} тенге и у вас осталось {remainderOfMoney} рублей");
                        }
                        else if (rub < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Обмен долларов на рубли");
                        Console.Write("Сколько у вас долларов?: ");
                        usd = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести долларов в рубли?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());
                        if (usd >= amountOfMoney)
                        {
                            rub = amountOfMoney * rubToUsd;
                            remainderOfMoney = usd - amountOfMoney;
                            Console.WriteLine($"Вы получили {rub} рублей и у вас осталось {remainderOfMoney} долларов");
                        }
                        else if (usd < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Обмен долларов на тенге");
                        Console.Write("Сколько у вас долларов?: ");
                        usd = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести долларов в тенге?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());
                        if (usd >= amountOfMoney)
                        {
                            kzt = amountOfMoney * kztToUsd;
                            remainderOfMoney = usd - amountOfMoney;
                            Console.WriteLine($"Вы получили {kzt} тенге и у вас осталось {remainderOfMoney} долларов");
                        }
                        else if (usd < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }

                        break;

                    case "5":
                        Console.WriteLine("Обмен тенге на доллары");
                        Console.Write("Сколько у вас тенге?: ");
                        kzt = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести тенге в доллары?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());
                        if (kzt >= amountOfMoney)
                        {
                            usd = amountOfMoney / kztToUsd;
                            remainderOfMoney = kzt - amountOfMoney;
                            Console.WriteLine($"Вы получили {usd} долларов и у вас осталось {remainderOfMoney} тенге");
                        }
                        else if (kzt < amountOfMoney)
                        {
                            Console.WriteLine("У вас недостаточно денег");
                        }
                        break;
                    case "6":
                        Console.WriteLine("Обмен тенге на рубли");
                        Console.Write("Сколько у вас тенге?: ");
                        kzt = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Сколько вы хотите перевести тенге в рубли?: ");
                        amountOfMoney = Convert.ToSingle(Console.ReadLine());
                        if (kzt >= amountOfMoney)
                        {
                            rub = amountOfMoney * rubToKzt;
                            remainderOfMoney = kzt - amountOfMoney;
                            Console.WriteLine($"Вы получили {rub} рублей и у вас осталось {remainderOfMoney} тенге");
                        }
                        else if (kzt < amountOfMoney)
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
