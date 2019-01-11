using System;

namespace DetectLoopLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var head1 = GetLinkedListWithNoLoop();
            var isLoopExist1 = IsLoopExist(head1);
            if(!isLoopExist1)
                Console.WriteLine("The loop doesn't exist.");

            var head2 = GetLinkedListWithLoop();
            var isLoopExist2 = IsLoopExist(head2);
            if(isLoopExist2)
                Console.WriteLine("The loop exists.");
            Console.ReadLine();
        }

        static Node GetLinkedListWithNoLoop()
        {
            var head = new Node() { Value = 1 };
            var node2 = new Node() { Value = 2 };
            var node3 = new Node() { Value = 3 };
            var node4 = new Node() { Value = 4 };

            head.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            return head;
        }

        static Node GetLinkedListWithLoop()
        {
            var head = new Node() { Value = 1 };
            var node2 = new Node() { Value = 2 };
            var node3 = new Node() { Value = 3 };
            var node4 = new Node() { Value = 4 };
            var node5 = new Node() { Value = 5 };

            head.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node2;
            return head;
        }

        static bool IsLoopExist(Node head)
        {
            if (head == null)
                return false;
            Node slowPointer = head;
            Node fastPointer = head;
            while (fastPointer != null)
            {
                fastPointer = fastPointer.Next;
                if (fastPointer == slowPointer)
                    return true;
                if (fastPointer != null)
                {
                    fastPointer = fastPointer.Next;
                    slowPointer = slowPointer.Next;
                }
                if (fastPointer == slowPointer)
                    return true;
            }
            return false;
        }
    }
}
