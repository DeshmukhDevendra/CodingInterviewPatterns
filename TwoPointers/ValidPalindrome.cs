using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterviewPatterns.TwoPointers
{
    internal class ValidPalindrome
    {
        public bool Solve(string str)
        {
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                while (left < right && !char.IsLetterOrDigit(str[left]))
                {
                    left++;
                }
                while (left < right && !char.IsLetterOrDigit(str[right]))
                {
                    right--;
                }
                if (char.ToLower(str[left]) != char.ToLower(str[right]))
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

    }
}
