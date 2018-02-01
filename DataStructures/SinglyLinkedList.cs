
namespace DataStructures
{
    public class ListNode<T>
    {
        T data;
        ListNode<T> next;

        public ListNode(T value)
        {
            data = value;
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public ListNode<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
    public class SinglyLinkedList<T>
    {
        ListNode<T> head;
        
        public SinglyLinkedList()
        {
            head = null;
        }

        public ListNode<T> Head
        {
            get { return head; }
        }

        public ListNode<T> FindElement(T data)
        {
            ListNode<T> node = head;
            while (node != null && !node.Data.Equals(data)) 
            {
                node = node.Next;
            }

            return node;
        }

        public void AddToTheEnd(T data)
        {
            if (head == null)
            {
                head = new ListNode<T>(data);
                return;
            }

            ListNode<T> node = head;
            while (node.Next != null)
            {
                node = node.Next; 
            }

            node.Next = new ListNode<T>(data);
        }

        public void Insert(T data)
        {
            ListNode<T> node = new ListNode<T>(data);
            node.Next = head;
            head = node;
        }

        public bool DeleteNode(T data)
        {
            if (head == null)
            {
                return false;
            }

            if (head.Data.Equals(data))
            {
                head = head.Next;
                return true;
            }

            ListNode<T> node = head;
            while (node.Next != null)
            {
                if (node.Next.Data.Equals(data))
                {
                    node.Next = node.Next.Next;
                    return true;
                }
                node = node.Next;
            }
            return false;
        }
    }
}
