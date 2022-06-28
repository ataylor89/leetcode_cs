using System;
using System.Diagnostics;

public class Statistics {
    public static void display(Stopwatch s) {
        using (Process myProcess = Process.GetCurrentProcess()) {
            Console.WriteLine("==== Diagnostics ====");
            // Time it took to run the algorithm
            Console.WriteLine($"  Time for execution         : {s.Elapsed.TotalMilliseconds}ms");
            // Process statistics
            Console.WriteLine($"  Physical memory usage      : {Math.Round(myProcess.WorkingSet64/Math.Pow(10,6), 1)}MB");
            Console.WriteLine($"  Base priority              : {myProcess.BasePriority}");
            Console.WriteLine($"  Priority class             : {myProcess.PriorityClass}");
            Console.WriteLine($"  User processor time        : {myProcess.UserProcessorTime}");
            Console.WriteLine($"  Privileged processor time  : {myProcess.PrivilegedProcessorTime}");
            Console.WriteLine($"  Total processor time       : {myProcess.TotalProcessorTime}");
            Console.WriteLine($"  Paged system memory size   : {Math.Round(myProcess.PagedSystemMemorySize64/Math.Pow(10,6), 1)}MB");
            Console.WriteLine($"  Paged memory size          : {Math.Round(myProcess.PagedMemorySize64/Math.Pow(10,6), 1)}MB");
            // Peak memory statistics 
            Console.WriteLine($"  Peak physical memory usage : {Math.Round(myProcess.PeakWorkingSet64/Math.Pow(10,6), 1)}MB");
            Console.WriteLine($"  Peak paged memory usage    : {Math.Round(myProcess.PeakPagedMemorySize64/Math.Pow(10,6), 1)}MB");
            Console.WriteLine($"  Peak virtual memory usage  : {Math.Round(myProcess.PeakVirtualMemorySize64/Math.Pow(10,9), 1)}GB");
            // Process info
            Console.WriteLine($"  Machine name               : {myProcess.MachineName}");
            Console.WriteLine($"  Process name               : {myProcess.ProcessName}");
            Console.WriteLine($"  Process ID                 : {myProcess.Id}");
            Console.WriteLine($"  Process start time:        : {myProcess.StartTime}");
        }
    }
}