using System.IO;
using System.Text;
namespace PuzzleSharp.DataStructures
{
    class LinkedList
    {
        static void Main(string[] args)
        {
            SinglyLinkedList o = new SinglyLinkedList();
            o.InsertNode(1);
            o.InsertNode(2);
            o.InsertNode(3);
            o.DeleteNode(2);
            o.DeleteNode(3);
            o.DeleteNode(1);
            PrintSinglyLinkedList(o.head);
            //	using(var txtwriter = System.IO.File.CreateText(@"c:\AAA\newfile.txt"))
            //	{
            //		PrintSinglyLinkedList(o.head,"hello",txtwriter);
            //	}
        }
        static string PrintSinglyLinkedList(SinglyLinkedListNode node)
        {
            var sb = new StringBuilder();
            while (node != null)
            {
                sb.Append(node.data);
                node = node.next;
            }
            return sb.ToString();
        }
        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
        {
            while (node != null)
            {
                textWriter.Write(node.data);
                node = node.next;
            }
            if (node != null)
            {
                textWriter.Write(sep);
            }
        }
    }
    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }
        public void DeleteNode(int nodeData)
        {
            SinglyLinkedListNode previousNode = null;
            SinglyLinkedListNode currentNode = null;

            if (this.head == null)
                return;

            if (this.head.data == nodeData)
            {
                //this.head == this.head.next;
                if (this.head == null)
                    this.tail = null;
                return;
            }

            while (currentNode != null)
            {
                if (currentNode.data == nodeData)
                {
                    if (previousNode == null) //header has to be removed.
                    {
                        this.head = null;
                        this.tail = null;
                        break;
                    }
                    previousNode.next = currentNode.next;
                    break;
                }
                previousNode = currentNode;
                currentNode = currentNode.next;
            }
        }
        public void InsertNode(int nodeData)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }
            this.tail = node;
        }
    }
}
