
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

var queue = new Problem03.Queue.Queue<int>();

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);


Console.WriteLine(String.Join(" ", queue));

Console.WriteLine(queue.Dequeue());