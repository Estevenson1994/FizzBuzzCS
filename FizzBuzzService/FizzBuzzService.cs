using System;

namespace FizzBuzz.Service
{
    public class FizzBuzzService
    {
        public string Convert(int num)
        {
            string result = "";
            result += ((num % 3 == 0) ? "Fizz" : "");
            result += ((num % 5 == 0) ? "Buzz" : "");
            result = ((result.Equals("")) ? num.ToString() : result);
            return result;

        }
    }
}
