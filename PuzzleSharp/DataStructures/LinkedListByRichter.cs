namespace PuzzleSharp.DataStructures
{
    using System;
    namespace PuzzleSharp
    {
        class PrimeNumber
        {
            static void Main(string[] args)
            {
                Node<char> head = new Node<char>('C');
                head = new Node<char>('B', head);
                head = new Node<char>('D', head);
                Console.WriteLine(head.ToString());
            }
            internal sealed class Node<T>
            {
                public T m_data;
                public Node<T> m_next;
                public Node(T data) : this(data, null) { }
                public Node(T data, Node<T> next)
                {
                    m_data = data;
                    m_next = next;
                }
                public override string ToString()
                {
                    return m_data.ToString() + ((m_next != null)
                            ? m_next.ToString() : String.Empty);
                }
            }
        }
    }
}
