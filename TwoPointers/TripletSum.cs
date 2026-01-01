using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterviewPatterns.TwoPointers
{
    internal class TripletSum
    {
        #region Triplet Sum
        public List<int[]> Solve(int[] nums, int target)
        {
            List<int[]> seen = new List<int[]>();
            if (nums.Length < 3)
            {
                return seen;
            }
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == target)
                        {
                            var triplet = new int[] { nums[i], nums[j], nums[k] };
                            Array.Sort(triplet);
                            seen.Add(triplet);
                        }
                    }
                }
            }
            return seen;
        }

        public List<int[]> SolveOptimized(int[] nums, int target)
        {
            Array.Sort(nums);
            List<int[]> seen = new List<int[]>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    break;
                }
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                var triplets = TwoPointerTechniqueForTriplet(nums, -nums[i], i);
                seen.AddRange(triplets);
            }
            return seen;
        }

        //Note : here fixedIndex is the index of the current element being considered as the first element of the triplet.
        public static List<int[]> TwoPointerTechniqueForTriplet(int[] nums, int target, int fixedIndex)
        {
            List<int[]> seen = new List<int[]>();
            int left = fixedIndex + 1;
            int right = nums.Length - 1;
            while (left < right)
            {
                int currentSum = nums[left] + nums[right];
                if (currentSum == target)
                {
                    var triplet = new int[] { nums[fixedIndex], nums[left], nums[right] };

                    seen.Add(triplet);

                    left++;

                    // Skip duplicates for left pointer
                    while (left < right && nums[left] == nums[left - 1])
                    {
                        left++;
                    }
                }
                else if (currentSum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return seen;
        }

        #endregion

    }
}
