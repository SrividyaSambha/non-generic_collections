using System;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add("vidya");
        arrayList.Add(48);
        arrayList.Add(5.2);
        arrayList.Add(true);
        arrayList.Remove(5.2);
        foreach(object obj in arrayList)
        {
            Console.WriteLine(obj);
        }
        Hashtable ht = new Hashtable();
        ht.Add("id", 201);
        ht.Add("name", "vidya");
        ht.Add("dept", "eee");
        ht.Add("ph no", 487656789);
        foreach (object keys in ht.Keys)
        {
            Console.WriteLine(keys+" "+ht[keys]);
        }
        Stack stack = new Stack();
        stack.Push(345);
        stack.Push("jhuh");
        stack.Push('v');
        stack.Push(9.999);
        stack.Peek();
        stack.Pop();
        foreach (object obj1 in stack)
        {
            Console.WriteLine(obj1);
        }
        Queue queue = new Queue();
        queue.Enqueue('a');
        queue.Enqueue(2);
        queue.Enqueue(3.9876);
        queue.Enqueue(4.887);
        queue.Enqueue("hjfjvbh");
        queue.Dequeue();
        foreach (object obj2 in queue)
        {
            Console.WriteLine(obj2);
        }

    }
}
