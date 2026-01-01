namespace CodingInterviewPatterns.Dictionaries;

public class PairSumUnsorted
{
/*
    input nums = [-1,3,4,2], target = 3
    output = [0,2] // -1 + 4 = 3

    Approach : x + y = target
    y = target - x
*/
    public int[] Solve(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i]; // this can be re-written in without using complement variable
            map.Add(nums[i], i);
            if (map.ContainsKey(complement)) // can be written as if (map.ContainsKey(target - nums[i]))
            {
                return new int[] { map[complement], i }; // can be written as return new int[] { map[target - nums[i]], i
            }
        }
        return Array.Empty<int>();
    }
}
