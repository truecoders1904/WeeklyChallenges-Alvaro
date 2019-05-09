using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEven += numbers[i];
                }
                else if (numbers[i] % 2 != 0)
                {
                    sumOdd += numbers[i];
                }
            }
            return sumEven - sumOdd;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            if (str1.Length <= str2.Length && str1.Length <= str3.Length && str1.Length <= str4.Length)
                return str1.Length;
            else if (str2.Length <= str1.Length && str2.Length <= str3.Length && str2.Length <= str4.Length)
                return str2.Length;
            else if (str3.Length <= str1.Length && str3.Length <= str2.Length && str3.Length <= str4.Length)
                return str3.Length;
            else
                return str4.Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            if (number1 <= number2 && number1 <= number3 && number1 <= number4)
                return number1;
            else if (number2 <= number1 && number2 <= number3 && number2 <= number4)
                return number2;
            else if (number3 <= number1 && number3 <= number2 && number3 <= number4)
                return number3;
            else
                return number4;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength3 + sideLength1 > sideLength2;
        }

        public bool IsStringANumber(string input)
        {
            if (String.IsNullOrEmpty(input))
                return false;
            foreach (char c in input)
            {
                if (!char.IsDigit(c) && c != '.' && c != '-')
                {
                    return false;
                }
            }
            return true;
        }
        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int i, count = 0;
            for (i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                    count++;
            }
            if (count > objs.Length / 2)
                return true;
            else
            return false;

        }
        public double AverageEvens(int[] numbers)
        {
            double count = 0;
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                    count++;
                }
            }
            if (count == 0)
                return 0;
            return sum / count;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                int factorial = 1;
                for (int i = 1; i <= number; i++)
                {

                    factorial = factorial * i;
                }

                return factorial;
            }
        }
    }
}
