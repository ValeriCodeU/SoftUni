
// Problem 1. List

//var list = new Problem01.List.List<int>();

//var numbers = new int[] { 3, 5, 7, 1, -5, -100 };
//foreach (var num in numbers)

//{
//    list.Add(num);
//}

//list.Insert(1,100);


//Console.WriteLine(String.Join(" ", list));

//Problem 2. Stack

//var stack = new Problem02.Stack.Stack<int>();

//stack.Push(1);
//stack.Push(2);
//stack.Push(3);


//Console.WriteLine(String.Join(" ", stack));
//Console.WriteLine(stack.Peek());

//Problem 3. Queue

//var queue = new Problem03.Queue.Queue<int>();

//queue.Enqueue(1);
//queue.Enqueue(2);
//queue.Enqueue(3);


//Console.WriteLine(String.Join(" ", queue));

//Console.WriteLine(queue.Dequeue());

//var linkedList = new Problem04.SinglyLinkedList.SinglyLinkedList<int>();

//linkedList.AddFirst(1);
//linkedList.AddFirst(2);
//linkedList.AddFirst(3);


//Console.WriteLine(String.Join(" ", linkedList));

//var linkedList = new Problem04.SinglyLinkedList.SinglyLinkedList<int>();

//linkedList.AddLast(1);
//linkedList.AddLast(2);
//linkedList.AddLast(3);


//Console.WriteLine(String.Join(" ", linkedList));

var linkedList = new Problem04.SinglyLinkedList.SinglyLinkedList<int>();

linkedList.AddLast(1);
linkedList.AddLast(2);
linkedList.AddLast(3);
linkedList.AddLast(4);
linkedList.AddLast(5);
linkedList.AddLast(6);

linkedList.RemoveLast();
linkedList.RemoveLast();

Console.WriteLine(linkedList.Count);

Console.WriteLine(String.Join(" ", linkedList));
