using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> linkedList = new LinkedList<int>();

        linkedList.AddLast(10);
        linkedList.AddLast(20);
        linkedList.AddLast(30);
        linkedList.AddLast(40);
        linkedList.AddLast(50);

        // Retrieve and display the first node
        LinkedListNode<int> firstNode = linkedList.First;
        Console.WriteLine("First node: " + firstNode.Value);

        // Retrieve and display the last node
        LinkedListNode<int> lastNode = linkedList.Last;
        Console.WriteLine("Last node: " + lastNode.Value);

        LinkedListNode<int> middleNode = linkedList.Find(30); // Finding a node with value 30
        linkedList.AddAfter(middleNode, 35);

        linkedList.RemoveLast();

        int itemCount = linkedList.Count;
        Console.WriteLine("Number of items in the linked list: " + itemCount);

        Console.WriteLine("Items in the linked list:");
        foreach (int item in linkedList)
        {
            Console.WriteLine(item);
        }
    }
}