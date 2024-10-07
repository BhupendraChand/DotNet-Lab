using System;
using System.Collections.Generic;

internal class qno4
{
    public static void Main(string[] args)
    {
     
        List<string> list = new List<string>();
        list.Add("Computer Network");
        list.Add("DOTNET Technology");
        list.Add("Introduction to Management");
        list.Add("Computer Graphics");

        Console.WriteLine("*********** All Courses (List) ***********");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        list.Remove("Computer Network");
        Console.WriteLine("*********** After Removing Course (List) **************");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
       
        Stack<int> stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("*********** Stack<T> Demonstration ***********");
        Console.WriteLine("Popping from stack =" + stack.Pop());
        Console.WriteLine("Top of stack after pop = " + stack.Peek());
        Console.WriteLine();
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        Console.WriteLine("*********** Queue<T> Demonstration ***********");
        Console.WriteLine("Dequeueing from queue = " + queue.Dequeue());
        Console.WriteLine("Front of queue after dequeue = " + queue.Peek());
        Console.WriteLine();

        LinkedList<string> linkedList = new LinkedList<string>();
        linkedList.AddLast("Node 1");
        linkedList.AddLast("Node 2");
        linkedList.AddLast("Node 3");

        Console.WriteLine("*********** LinkedList<T> Demonstration ***********");
        foreach (var node in linkedList)
        {
            Console.WriteLine(node);
        }

        Console.WriteLine();
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(101, "John");
        dictionary.Add(102, "Romeo");
        dictionary.Add(103, "David");

        Console.WriteLine("*********** Dictionary<TKey, TValue> Demonstration ***********");
        foreach (var kvp in dictionary)
        {
            Console.WriteLine("Key = " + kvp.Key + ", Value = " + kvp.Value);
        }

        Console.ReadKey();
    }
}
