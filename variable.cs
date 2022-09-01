using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Porshin";
            string lastName = "Vasya";
            string swapString;
            Console.WriteLine($"{firstName}  {lastName}");
            swapString = firstName;
            firstName = lastName; 
            lastName = swapString;
            Console.WriteLine($"{firstName}  {lastName}");
        } 
    }
}
