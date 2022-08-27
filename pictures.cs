using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPicturesInRow = 3;
            int pictures = Convert.ToInt32(Console.ReadLine());
            int numberOfRows = pictures / numberOfPicturesInRow;
            int numberOfExtraPictures = pictures % numberOfPicturesInRow;
            Console.WriteLine($"Колличество полностью заполненных рядов картинками равно {numberOfRows}");
            Console.WriteLine($"Колличество картинок которые не вошли в полный ряд равно {numberOfExtraPictures}");
        }
    }
}
