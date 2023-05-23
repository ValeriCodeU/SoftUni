
var list = new Problem01.List.List<int>();

var numbers = new int[] { 3, 5, 7, 1, -5, -100 };
foreach (var num in numbers)

{
    list.Add(num);
}

list.Insert(1,100);


Console.WriteLine(String.Join(" ", list));