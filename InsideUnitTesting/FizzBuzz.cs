using System;
using System.Collections.Generic;
using System.Text;

namespace InsideUnitTesting
{
    public class FizzBuzz
    {
        public bool isDivisibleByThree(int n)
        {
            return (n % 3) == 0;
        }
        public bool isDivisibleByFive(int n)
        {
            return (n % 5) == 0;
        }

        public string getResultForNumber(int n)
        {
            if (isDivisibleByThree(n) && isDivisibleByFive(n))
                return "FizzBuzz";
            else if (isDivisibleByFive(n))
                return "Buzz";
            else if (isDivisibleByThree(n))
                return "Fizz";
            else
                return n.ToString();
        }

        public string getResultStringForFizzBuzz(int upperLimit)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= upperLimit; i++)
                sb.AppendFormat("{0}, ", getResultForNumber(i));

            return sb.ToString().Substring(0, sb.Length - 2);
        }

        public string[] getResultArrayForFizzBuzz(int upperLimit)
        {
            string[] results = new string[upperLimit];

            for (int i = 0; i < upperLimit; i++)
                results[i] = getResultForNumber(i+1);

            return results;
        }
    }

    public class FizzBuzzReport
    {
        public string getResultStringForFizzBuzz(int upperLimit)
        {
            FizzBuzz fb = new FizzBuzz();
            string[] results = fb.getResultArrayForFizzBuzz(15);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < upperLimit; i++)
                sb.AppendFormat("{0}, ", results[i]);

            return sb.ToString().Substring(0, sb.Length - 2);
        }
    }
}
