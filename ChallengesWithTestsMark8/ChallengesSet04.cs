using System;
using System.Xml.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0; 
            }

            int result = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    result += num; 
                }
                else
                {
                    result -= num; 
                }
            }

            return result;
        }



        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int minLength = str1.Length;

            if (str2.Length < minLength)
                minLength = str2.Length;

            if (str3.Length < minLength)
                minLength = str3.Length;

            if (str4.Length < minLength)
                minLength = str4.Length;

            return minLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallest = number1; 

            if (number2 < smallest)
                smallest = number2;

            if (number3 < smallest)
                smallest = number3;

            if (number4 < smallest)
                smallest = number4;

            return smallest;
        }


        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            if (biz != null && biz.Name != null)
            {
                biz.Name = "TrueCoders";
            }
            else if (biz != null && biz.Name == null)
            {
                biz.Name = "TrueCoders";
            }

        }


        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false; 
            }

            if (sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1)
            {
                return true; 
            }

            return false; 
        }

        public bool IsStringANumber(string input)
        { 
            if (double.TryParse(input, out _))
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null || objs.Length == 0)
            {
                return false;
            }

            int countNull = 0;
            foreach (var item in objs)
            {
                if (item == null)
                {
                    countNull++;
                }
            }

            
            return countNull > objs.Length / 2;

        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int sum = 0;
            int count = 0;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                    count++; // Increment count for each even number
                }
            }

            if (count == 0)
            {
                return 0;
            }

            return (double)sum / count;
        }

        public int Factorial(int number)
        {
            
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int result = 1;

            
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
