using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
            
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;
            if (length1 < length2)
            {
                return length1;

            }
            else 
            {
                return length2;
            }
        }
        public int Sum(int[] numbers)
        {
            if (numbers == null)
                return 0;
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
                return 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0) 
                {
                    sum += number;
                }
                
               
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if (numbers == null)
                return false;
            foreach (int number in numbers)
            {       
                 
                sum += number;
            }

            return sum % 2 != 0;
            

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0; 
           for (long i = 1; i <number; ++i)
               
            {
                if ((i % 2) != 0)
                { 
                 count++;
                }
            }
           return count;    
        }
    }
}
