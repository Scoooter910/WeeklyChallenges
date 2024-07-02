﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
           
            int remainder = startNumber % n;

            if (remainder == 0)
            {
                return startNumber + n;
            }
            else
            {
                return startNumber + (n - remainder);
            }
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                return 0;
            }

            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)  
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            List<string> filteredWords = new List<string>();
            foreach (var word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    filteredWords.Add(word.Trim());
                }
            }

            
            string sentence = string.Join(" ", filteredWords);

            
            if (!string.IsNullOrEmpty(sentence))
            {
                sentence = sentence.TrimEnd() + ".";
            }

            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[] { }; 
            }

            List<double> result = new List<double>();

           
            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            
            HashSet<int> seen = new HashSet<int>();

            
            foreach (int num in nums)
            {
                
                int complement = targetNumber - num;

                
                if (seen.Contains(complement))
                {
                    
                    return true;
                }

                
                seen.Add(num);
            }

            return false;
        }
    }
}
