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
        int carry = 0;
        ListNode sum = new ListNode();
        ListNode tail = sum;
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
            if (l1 == null && l2 == null)
                keepGoing = false;
            else {
                tail.next = new ListNode();
                tail = tail.next;
            }
        }
        if (carry > 0) {
            tail.next = new ListNode();
            tail = tail.next;
            tail.val = carry;
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
        using (Process process = Process.GetCurrentProcess()) {
            double peakMemoryUsage = process.PeakWorkingSet64 / Math.Pow(10, 6);
            double currMemoryUsage = process.WorkingSet64 / Math.Pow(10, 6);
            Console.WriteLine($"Current physical memory usage: {currMemoryUsage}MB");
            Console.WriteLine($"Peak physical memory usage: {peakMemoryUsage}MB");
        }
    }
}