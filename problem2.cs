/*
 * There are two ways of adding really big numbers in a computer program.
 *
 * One way is to use linked lists. A linked list can store a number of arbitrary size (thousands or millions of digits long).
 * We can store two big numbers as linked lists, and then add them using an algorithm.
 * The algorithm produces a third linked list, which corresponds to the sum of the two input numbers.
 *
 * A second way is to use strings. We can store a really big number in a string.
 * If we want to add two really big numbers, we can store each of them as strings, and then perform an algorithm
 * on the two strings that produces a third string, corresponding to the sum of the two really big numbers.
 *
 * In this file we take the linked list approach. A ListNode is a node in a linked list.
 * A ListNode stores a single digit in a number. A linked list of ListNodes stores a number.
 *
 * The head node of a linked list is enough to give us every node in the linked list, and therefore every digit in a number.
 * This is why the arguments to the AddTwoNumbers function are the respective head nodes of two linked lists.
 *
 * In the AddTwoNumbers function, we iterate through the two linked lists and add every digit.
 *
 * This code can be run on Windows or Mac using the command-line tools that come with Visual Studio (see the Readme for more information.)
 */

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

        public int intValue() {
            ListNode node = this;
            int sum = 0;
            int power = 1;
            while (node != null) {
                sum += node.val * power;
                power *= 10;
                node = node.next;
            }
            return sum;
        }

        public static ListNode toLinkedList(int num) {
            ListNode head = new ListNode();
            ListNode tail = head;
            while (num > 0) {
                tail.val = num % 10;
                num = num/10;
                if (num > 0) {
                    tail.next = new ListNode();
                    tail = tail.next;
                }
            }
            return head;
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
        int num1 = 942;
        int num2 = 9465;
        ListNode node1 = ListNode.toLinkedList(num1);
        ListNode node2 = ListNode.toLinkedList(num2);
        Stopwatch s = new Stopwatch();
        s.Start();
        ListNode node3 = sol.AddTwoNumbers(node1, node2);
        s.Stop();
        int sum = node3.intValue();
        Console.WriteLine($"Number1: {num1}");
        Console.WriteLine($"Number2: {num2}");
        Console.WriteLine($"Sum: {sum}");
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
            // Display process info
            Console.WriteLine($"  Machine name               : {myProcess.MachineName}");
            Console.WriteLine($"  Process name               : {myProcess.ProcessName}");
            Console.WriteLine($"  Process ID                 : {myProcess.Id}");
            Console.WriteLine($"  Process start time:        : {myProcess.StartTime}");
        }
    }
}