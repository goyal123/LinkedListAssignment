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
            Mylist.display();



        }
    }
}