using Problem01.CircularQueue;
using Problem03.ReversedList;

//var queue = new CircularQueue<int>();

//queue.Enqueue(1);
//queue.Enqueue(2);
//queue.Enqueue(3);
//queue.Enqueue(4);
//queue.Enqueue(5);
//queue.Dequeue();
//queue.Dequeue();
//queue.Dequeue();

//Console.WriteLine(String.Join(", ", queue));
//Console.WriteLine(queue.Peek());

var list = new ReversedList<int>();

list.Add(10);
list.Add(11);
list.Add(2);
list.Add(4);
list.Add(15);

Console.WriteLine(String.Join(", ", list));

list.RemoveAt(1);

Console.WriteLine(String.Join(", ", list));