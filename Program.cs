using CodingInterviewPatterns.Dictionaries;
using CodingInterviewPatterns.TwoPointers;
public class Program
{
    public static void Main(string[] args)
    {
        //Two Pointers
        PairSumSorted();
        TripletSum();
        ValidPalindrome();
        LargestContainerArea();

        //Dictionaries
        PairSumUnsorted();


        Console.ReadLine();
    }

    static void PairSumSorted()
    {
        int[] nums = { -5, 2, 3, 4, 6 };
        int target = 7;

        var problem = new PairSumSorted();
        var result = problem.Solve(nums, target);

        if (result.Length == 2)
        {
            Console.WriteLine($"Pair found: [{result[0]}, {result[1]}]");
        }
        else
        {
            Console.WriteLine("No pair found.");
        }

        result = problem.SolveOptimized(nums, target);

        if (result.Length == 2)
        {
            Console.WriteLine($"Pair found Optimized: [{result[0]}, {result[1]}]");
        }
        else
        {
            Console.WriteLine("No pair found.");
        }
    }

    static void TripletSum()
    {
        int[] nums = { 0, -1, 2, -3, 1 };
        int target = 0;

        var problem = new TripletSum();
        //var result = problem.Solve(nums, target);

        var result = problem.SolveOptimized(nums, target);

        if (result.Count > 0)
        {
            foreach (var triplet in result)
            {
                Console.WriteLine($"Triplet : {triplet}");
            }
        }
        else
        {
            Console.WriteLine("No triplet found.");
        }
    }

    static void ValidPalindrome()
    {
        string str = "a dog, a panic in a pagoda";
        var problem = new ValidPalindrome();
        bool isPalindrome = problem.Solve(str);
        Console.WriteLine($"{str} Is the string a palindrome? {isPalindrome}");

        //Test case with mixed case
        str = "";
        isPalindrome = problem.Solve(str);
        Console.WriteLine($"{str} Is the string a palindrome? {isPalindrome}");

        str = "a";
        isPalindrome = problem.Solve(str);
        Console.WriteLine($"{str} Is the string a palindrome? {isPalindrome}");

        str = "aa";
        isPalindrome = problem.Solve(str);
        Console.WriteLine($"{str} Is the string a palindrome? {isPalindrome}");

        str = "ab";
        isPalindrome = problem.Solve(str);
        Console.WriteLine($"{str} Is the string a palindrome? {isPalindrome}");

        str = "!, (?)";
        isPalindrome = problem.Solve(str);
        Console.WriteLine($"{str} Is the string a palindrome? {isPalindrome}");

        str = "12.02.2021";
        isPalindrome = problem.Solve(str);
        Console.WriteLine($"{str} Is the string a palindrome? {isPalindrome}");

        str = "hello, world";
        isPalindrome = problem.Solve(str);
        Console.WriteLine($"{str} Is the string a palindrome? {isPalindrome}");
    }

    static void LargestContainerArea() 
    {

        int[] heights = { 2, 7, 8, 3, 7, 6 };
        var problem = new LargestContainerArea();
        int maxArea = problem.Solve(heights);
        Console.WriteLine($"The largest container area is: {maxArea}");

        maxArea = problem.SolveOptimized(heights);
        Console.WriteLine($"The largest container area Optimized is: {maxArea}");

        // Additional test cases
        heights = new int[] { };
        maxArea = problem.SolveOptimized(heights);
        Console.WriteLine($"The largest container area for empty array is: {maxArea}");

        heights = new int[] { 5 };
        maxArea = problem.SolveOptimized(heights);
        Console.WriteLine($"The largest container area for single element array is: {maxArea}");

        heights = new int[] { 0, 1, 0 };
        maxArea = problem.SolveOptimized(heights);
        Console.WriteLine($"The largest container area for zero height elements is: {maxArea}");

        heights = new int[] { 3, 3, 3, 3 };
        maxArea = problem.SolveOptimized(heights);
        Console.WriteLine($"The largest container area for equal height elements is: {maxArea}");

        heights = new int[] { 1, 2, 3 };
        maxArea = problem.SolveOptimized(heights);
        Console.WriteLine($"The largest container area for increasing height elements is: {maxArea}");

        heights = new int[] { 3, 2, 1 };
        maxArea = problem.SolveOptimized(heights);
        Console.WriteLine($"The largest container area for decreasing height elements is: {maxArea}");
    }

    static void PairSumUnsorted() 
    {
        var problem = new PairSumUnsorted();
        int[] result = problem.Solve(new int[] { -1, 3, 4, 2 }, 3);
        Console.WriteLine(string.Join(",", result));
    }
}