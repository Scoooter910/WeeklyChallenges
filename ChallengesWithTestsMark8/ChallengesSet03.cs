using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool value in vals)
            { 
            if (!value)
                {
                    {
                        return true;
                    }
                }
            
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false; 
            }

            int sumOfOdds = 0;
            bool hasOddNumbers = false;

            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    sumOfOdds += number;
                    hasOddNumbers = true;
                }
            }

            if (!hasOddNumbers)
            {
                return false; 
            }

            return sumOfOdds % 2 != 0; 
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false; 
            }

            bool hasLowercase = false;
            bool hasUppercase = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsLower(c))
                {
                    hasLowercase = true;
                }
                else if (char.IsUpper(c))
                {
                    hasUppercase = true;
                }
                else if (char.IsDigit(c))
                {
                    hasDigit = true;
                }

                
                if (hasLowercase && hasUppercase && hasDigit)
                {
                    return true;
                }
            }

            return false; 
        }

       
        public char GetFirstLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                throw new ArgumentException("Input string cannot be null or empty.");
            }

            return val[0]; 
        }
        public char GetLastLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                throw new NotImplementedException("Input string cannot be null or empty");
            }
            return val[val.Length - 1]; 
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0; 
            }

            return dividend / divisor; 
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                throw new ArgumentException("Input array cannot be null or empty.");
            }

            return nums[^1] - nums[0]; 
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = new int[50]; 
            int index = 0;

            for (int i = 1; i < 100; i += 2)
            {
                odds[index] = i;
                index++;
            }

            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            if (words == null)
            {
                throw new ArgumentNullException(nameof(words), "Input array cannot be null.");
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != null)
                {
                    words[i] = words[i].ToUpper(); 
                }
            }
        }
    }
}
