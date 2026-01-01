using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterviewPatterns.TwoPointers
{
    internal class PairSumSorted
    {
        #region Pair Sum Sorted
        /*

        Problem: Given a sorted array of integers, find a pair of numbers that sum up to a specific target value.
        Note: The array is sorted in ascending order.

        input:
             nums = [-5,2,3,4,6]
             target = 7

        output:  [2,3]

        Explanation: The pair (2, 3) sums up to the target value of 7.

        */
        // This solution is O(n^2) time complexity and O(1) space complexity
        public int[] Solve(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return [0];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return [i, j];
                    }
                }
            }
            return [0];
        }
        // This solution is O(n) time complexity and O(1) space complexity
        public int[] SolveOptimized(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                int sum = arr[left] + arr[right];
                if (sum == target)
                {
                    return [left, right];
                }
                if (sum < target)
                {
                    left++;
                }
                else if (sum > target)
                {
                    right--;
                }
            }
            return [0];
        }
        #endregion
    }
}
