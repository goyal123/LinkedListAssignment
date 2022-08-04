namespace LinkedList
{
    public class CustomLinkedList
    {
        public Node head;

        public void AddLast(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
                head = newnode;
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next= newnode;
            }

        }

        public void display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

       
        
    }
}

