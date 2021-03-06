using System;
using System.Diagnostics;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i+1; j < nums.Length; j++) {
                if (nums[i] + nums[j] == target)
                    return new int[2] {i, j};
            }
        }
        return null;
    }
    static void Main(string[] args) {
        Solution solution = new Solution();
        int[] nums = new int[4] {2,7,11,15};
        int target = 9;
        Stopwatch s = new Stopwatch();
        s.Start();
        int[] answer = solution.TwoSum(nums, target);
        s.Stop();
        Console.WriteLine($"i={answer[0]} j={answer[1]}");
        Statistics.display(s);
    }
}
