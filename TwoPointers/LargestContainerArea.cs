using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterviewPatterns.TwoPointers
{
    internal class LargestContainerArea
    {
        public int Solve(int[] heights)
        {
            if (heights.Length == 0)
            {
                return 0;
            }
            int maxArea = 0;
            int area = 0;
            for (int i = 0; i <= heights.Length; i++)
            {
                for (int j = i + 1; j < heights.Length; j++)
                {
                    if (heights[i] < heights[j])
                    {
                        area = heights[i] * (j - i);
                    }
                    else
                    {
                        area = heights[j] * (j - i);
                    }
                    if (area > maxArea)
                    {
                        maxArea = area;
                    }
                }
            }
            return maxArea;
        }
        public int SolveOptimized(int[] heights)
        {
            if (heights.Length == 0)
            {
                return 0;
            }
            int maxArea = 0;
            int left = 0;
            int right = heights.Length - 1;

            while (left < right)
            {
                int height = heights[left] < heights[right] ? heights[left] : heights[right];
                int width = right - left;
                int area = height * width;

                if (area > maxArea)
                {
                    maxArea = area;
                }

                if (heights[left] < heights[right])
                {
                    left++;
                }
                else if (heights[left] > heights[right])
                {
                    right--;
                }
                else
                {
                    left++;
                    right--;
                }
            }
            return maxArea;
        }
    }
}
