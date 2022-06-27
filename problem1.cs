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
        Console.WriteLine("==== Diagnostics ====");
        Console.WriteLine($"Time for execution: {s.Elapsed.TotalMilliseconds}ms");
        using (Process myProcess = Process.GetCurrentProcess()) {
            Console.WriteLine($"Current physical memory usage: {myProcess.PeakWorkingSet64/Math.Pow(10,6)}MB");
            Console.WriteLine($"Peak physical memory usage: {myProcess.WorkingSet64/Math.Pow(10,6)}MB");
            Console.WriteLine($"Current virtual memory usage: {myProcess.VirtualMemorySize64/Math.Pow(10,6)}MB");
            Console.WriteLine($"Peak virtual memory usage: {myProcess.PeakVirtualMemorySize64/Math.Pow(10,6)}MB");
            Console.WriteLine($"Private memory size: {myProcess.PrivateMemorySize64/Math.Pow(10,6)}MB");
            Console.WriteLine($"Total processor time: {myProcess.TotalProcessorTime.TotalMilliseconds}ms");
            Console.WriteLine($"Machine name: {myProcess.MachineName}");
            Console.WriteLine($"Process ID: {myProcess.Id}");
            Console.WriteLine($"Process name: {myProcess.ProcessName}");
            Console.WriteLine($"Process start time: {myProcess.StartTime}");
        }
    }
}