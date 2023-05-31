using Problem01.CircularQueue;

var queue = new CircularQueue<int>();

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();

Console.WriteLine(String.Join(", ", queue));
Console.WriteLine(queue.Peek());