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

        public void AddFirst(int data)
        {
            Node newnode = new Node(data);

            if (head == null)
                head = newnode;
            else
            {
                newnode.next = head;
                head = newnode;
            }
        }

        public void Insert(int data,int start,int end)
        {   Node newnode = new Node(data);
            Node temp = head;
            while(temp.data!=start && temp.next.data!=end)
            {
                temp = temp.next;
            }
            Node index = temp.next;
            temp.next = newnode;
            newnode.next = index;

        }

        public void RemoveFirst()
        {
            Node temp = head;
            if (head==null)
                Console.WriteLine("Linked List is empty");
            else
            {
                head = temp.next;
            }
        }

        public void RemoveLast()
        {
            Node temp = head;
            while(temp.next.next!=null)
            {
                temp = temp.next;
            }
            temp.next = null;
        }

        public void Find(int data)
        {
            Node temp = head;
            if (head==null)
                Console.WriteLine("Linked List is empty!");
            else
            {
                while(temp.data!=data)
                {
                    temp = temp.next;
                }
                if(temp.data==data)
                    Console.WriteLine("Node {0} is present",temp.data);
                else
                    Console.WriteLine("Node {0} is not present",temp.data);
            }
        }

        public void sort()
        {
            Node first = head;
            Node second = head;

            if (head == null)
                Console.WriteLine("Linked List is empty!");
            else
            {
                while (first != null)
                {
                    second = first.next;
                    while (second!= null)
                    {
                        if (first.data > second.data)
                        {
                            var temp = first.data;
                            first.data = second.data;
                            second.data = temp;
                        }

                        second = second.next;
                    }
                    first = first.next;
                }
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

