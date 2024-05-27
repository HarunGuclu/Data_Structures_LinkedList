// See https://aka.ms/new-console-template for more information
using SinglyLinkedList;

var linkedList= new SinglyLinkedList<string>();

linkedList.AddFirst("harun");
linkedList.AddFirst("mehmet");
linkedList.AddFirst("ahmet");
linkedList.AddFirst("islam");

linkedList.AddLast("Free");
linkedList.AddLast("Palestine");
linkedList.AddLast("Free");
linkedList.AddLast("Gaza");

linkedList.AddAfter(linkedList.Head.Next, "Turkey");
linkedList.AddBefore(linkedList.Head.Next, "Batman");

Console.WriteLine(linkedList.RemoveFirst());//islam
Console.WriteLine("--------");

Console.WriteLine(linkedList.RemoveLast());//Gaza
Console.WriteLine("--------");

linkedList.Remove("harun");//removed harun

foreach (var item in linkedList)
{
    Console.WriteLine(item);
}
