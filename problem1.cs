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
             // Display current process statistics
            Console.WriteLine($"  Physical memory usage      : {Math.Round(myProcess.WorkingSet64/Math.Pow(10,6), 1)}MB");
            Console.WriteLine($"  Base priority              : {myProcess.BasePriority}");
            Console.WriteLine($"  Priority class             : {myProcess.PriorityClass}");
            Console.WriteLine($"  User processor time        : {myProcess.UserProcessorTime}");
            Console.WriteLine($"  Privileged processor time  : {myProcess.PrivilegedProcessorTime}");
            Console.WriteLine($"  Total processor time       : {myProcess.TotalProcessorTime}");
            Console.WriteLine($"  Paged system memory size   : {Math.Round(myProcess.PagedSystemMemorySize64/Math.Pow(10,6), 1)}MB");
            Console.WriteLine($"  Paged memory size          : {Math.Round(myProcess.PagedMemorySize64/Math.Pow(10,6), 1)}MB");
            // Display peak memory statistics for the process
            Console.WriteLine($"  Peak physical memory usage : {Math.Round(myProcess.PeakWorkingSet64/Math.Pow(10,6), 1)}MB");
            Console.WriteLine($"  Peak paged memory usage    : {Math.Round(myProcess.PeakPagedMemorySize64/Math.Pow(10,6), 1)}MB");
            Console.WriteLine($"  Peak virtual memory usage  : {Math.Round(myProcess.PeakVirtualMemorySize64/Math.Pow(10,9), 1)}GB");
            // Display when the process started
            Console.WriteLine($"  Process start time:        : {myProcess.StartTime}");
        }
    }
}