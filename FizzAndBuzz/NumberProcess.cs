using System;
using System.Collections.Generic;
using System.Text;

namespace FizzAndBuzz
{
    public class NumberProcess
    {
        public string ShowFizzBuzzNumbers(int maxNumber)
        {
            if (maxNumber <= 0)
            {
                return "the input number must be larger than zero.";
            }
            List<string> numberStrs = new List<string>();
            for (int i = 1; i <= maxNumber; i++)
            {
                string numStr = i.ToString();

                if (i % 3 == 0 || i.ToString().Contains("3"))
                {
                    numStr = "Fizz";
                }
                if (i % 5 == 0 || i.ToString().Contains("5"))
                {
                    numStr = "Buzz";
                }
                if ((i % 3 == 0 && i % 5 == 0) || (i.ToString().Contains("3") && i.ToString().Contains("5")))
                {
                    numStr = "FizzBuzz";
                }
                numberStrs.Add(numStr);
            }
            return string.Join(" ", numberStrs);
        }
    }
}
