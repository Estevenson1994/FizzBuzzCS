﻿using System;

namespace FizzBuzz.Service
{
    public class FizzBuzzService
    {
        public string Convert(int num)
        {
            if (num % 3 == 0)
            {
                return "Fizz";
            }
            else if (num % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return num.ToString();
            }
        }
    }
}
