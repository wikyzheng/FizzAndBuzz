﻿using System;
using System.Collections.Generic;

namespace FizzAndBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberProcess numberProcess = new NumberProcess();
            string result = numberProcess.ShowFizzBuzzNumbers(50);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }



    
}
