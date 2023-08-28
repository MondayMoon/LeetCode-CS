
public class Problem1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int[] ans;
        int[] nums = { 2, 7, 11, 15 };
        Solution sol = new Solution();

        ans = sol.TwoSum(nums, 9);
        Console.WriteLine(string.Concat("ANS:=[", ans[0], ",", ans[1], "]"));

    }
}



public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int i, j;
        int[] ans = new int[2];

        for (i = 0; i < nums.Length; ++i)
        {
            for (j = i + 1; j < nums.Length; ++j)
            {
                if (nums[i] + nums[j] == target)
                {
                    ans[0] = i;
                    ans[1] = j;
                }
            }
        }
        return ans;
    }
}

