using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }

            foreach (string s in words)
            {
                if (s == null)
                {

                }
                else if ((s == word && ignoreCase == false) || (s.ToLower() == word.ToLower() && ignoreCase == true))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int uniques = -1;
            bool isDuplicate;
            for (int i = 0; i < str.Length; i++)
            {
                isDuplicate = false;

                for (int j = 0; j < str.Length; j++)
                {
                    if ((str[i] == str[j]) && i != j)
                    {
                        isDuplicate = true;
                    }
                }

                if (isDuplicate == false)
                {
                    uniques = i;   
                }
            }
            return uniques;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
             int count = 0;
             int consecutives = 0;
             for (int i = 0; i < numbers.Length; i++)
             {
                count = 0;
                 for (int j = i; j < numbers.Length; j++)
                 {
                     if (numbers[i] == numbers[j])
                     {
                        count += 1;
                     }
                    else if (numbers[i] != numbers[j])
                    {
                        i = j - 1;
                        break;
                    }
                 }
                 if (consecutives < count)
                    {
                    consecutives = count;
                    }
             }
             return consecutives; 
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> result = new List<double>();

            double[] arr = { };

            if (elements == null || n <= 0 || elements.Count == 0)
            {
                return arr;
            }
           
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    result.Add(elements[i]);
                }
            }
            return result.ToArray();
        }
    }
}
