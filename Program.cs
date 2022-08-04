namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wecome to Linked List");

            CustomLinkedList Mylist = new CustomLinkedList();
            /*
            Mylist.AddLast(56);
            Mylist.AddLast(30);
            Mylist.AddLast(70);
            Mylist.display();
            */

            Mylist.AddFirst(70);
            //Mylist.AddFirst(40);
            Mylist.AddFirst(56);
            Mylist.Insert(30,56,70);
            Console.WriteLine("Original Linked List");
            Mylist.display();
            Console.WriteLine("---------------------------");
            Console.WriteLine("After Removing First Element in Linked List");
            Console.WriteLine("---------------------------");
            Mylist.RemoveFirst();
            Mylist.display();
            Console.WriteLine("---------------------------");
            Console.WriteLine("After Removing Last Element in Linked List");
            Console.WriteLine("---------------------------");
            Mylist.RemoveLast();
            Mylist.display();
            Mylist.Find(30);
        }
    }
}