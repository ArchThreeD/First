﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exit;
            int age = 100;
            while(age-- > 0)
            {                
                Console.WriteLine("Hello");                
                exit= Console.ReadLine();
                if (exit == "exit")
                {
                   break;
                }
            }

        }
    }
}
