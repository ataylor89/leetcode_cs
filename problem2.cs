using System;
using System.Diagnostics;

public class Solution {

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
        public static ListNode toListNode(int num) {
            ListNode node = new ListNode();
            ListNode tail = node;
            while (num > 0) {
                tail.val = num % 10;
                num = num/10;
                if (num > 0) {
                    tail.next = new ListNode();
                    tail = tail.next;
                }
            }
            return node;
        }
        public static int fromListNode(ListNode node) {
            int sum = 0;
            int power = 1;
            while (node != null) {
                sum += node.val * power;
                power *= 10;
                node = node.next;
            }
            return sum;
        }
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode sum = new ListNode();
        ListNode tail = sum;
        int carry = 0;
        bool keepGoing = true;
        while (keepGoing)  {
            int val = carry;
            if (l1 != null) 
                val += l1.val;
            if (l2 != null) 
                val += l2.val;
            carry = (int) val/10;
            if (val > 9) 
                val = val % 10;
            tail.val = val;

            if (l1 != null) 
                l1 = l1.next;
            if (l2 != null)
                l2 = l2.next;

            if (l1 == null && l2 == null && carry == 0)
                keepGoing = false;
            else {
                tail.next = new ListNode();
                tail = tail.next;
            }
        }
        return sum;
    }

    static void Main(string[] args) {
        Solution sol = new Solution();
        int n1 = 942;
        int n2 = 9465;
        ListNode num1 = ListNode.toListNode(n1);
        ListNode num2 = ListNode.toListNode(n2);
        Stopwatch s = new Stopwatch();
        s.Start();
        ListNode sum = sol.AddTwoNumbers(num1, num2);
        s.Stop();
        int result = ListNode.fromListNode(sum);
        Console.WriteLine($"Number1: {n1}");
        Console.WriteLine($"Number2: {n2}");
        Console.WriteLine($"Sum: {result}");
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