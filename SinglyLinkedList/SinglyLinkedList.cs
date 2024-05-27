using System.Collections;

namespace SinglyLinkedList;

public class SinglyLinkedList<T> : IEnumerable<T>
{
    public SinglyLinkedListNode<T> Head { get; set; }

    public void AddFirst(T value)
    {
        var newNode = new SinglyLinkedListNode<T>(value);
        newNode.Next = Head;
        Head = newNode;
    }
    public void AddLast(T value)
    {
        var newNode = new SinglyLinkedListNode<T>(value);
        if (Head == null)
        {
            Head = newNode;
            return;
        }
        var current = Head;
        if (current.Next == null)
            Head = current;

        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
        current = newNode;
    }
    public void AddAfter(SinglyLinkedListNode<T> refNode, SinglyLinkedListNode<T> newNode, T value)
    {
        var Node = new SinglyLinkedListNode<T>(value);
        if (refNode == null || Node == null)
        {
            throw new ArgumentNullException("refNode and newNode cannot be null");
        }

        var current = Head;
        while (current.Next != null)
        {

            if (current == refNode)
            {
                Node.Next = current.Next;
                current.Next = Node;
                current = Node;
                return;
            }
            current = current.Next;
        }
    }
    public void AddAfter(SinglyLinkedListNode<T> node, T value)
    {
        var newNode = new SinglyLinkedListNode<T>(value);
        if (Head == null)
        {
            Head = newNode;
            return;
        }
        var current = Head;
        while (current.Next != null)
        {
            if (current.Next == node.Next)
            {
                newNode.Next = current.Next;
                current.Next = newNode;
                return;
            }
            current = current.Next;
        }
    }
    public void AddBefore(SinglyLinkedListNode<T> node, T value)
    {
        var newNode = new SinglyLinkedListNode<T>(value);
        if (node == null)
        {
            throw new ArgumentNullException("Node is empty");
        }

        if (Head == null)
        {
            throw new ArgumentNullException("Head is empty");
        }
        var current = Head;
        while (current.Next != null)
        {
            if (current.Next.Next == node.Next)
            {
                newNode.Next = node;
                current.Next = newNode;
                break;
            }
            current = current.Next;
        }

    }

    public IEnumerator<T> GetEnumerator()
    {
        return new SinglyLinkedListEnumerator<T>(Head);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public T RemoveFirst()
    {
        if (Head == null)
        {
            throw new ArgumentNullException();

        }
        var value = Head.Value;
        Head = Head.Next;
        return value;
    }
    public T RemoveLast()
    {
        var current = Head;
        SinglyLinkedListNode<T> prev = null;
        while (current.Next != null)
        {
            prev = current;
            current = current.Next;
        }
        prev.Next = null;
        return current.Value;
    }
    public void Remove(T item)
    {
        var current=Head;
        SinglyLinkedListNode<T> prev=null;
        while (current.Next != null)
        {
            prev = current;
            current = current.Next;
           
            if(current.Value.Equals(item))
            {
                prev.Next=current.Next;
            }
            
        }
    }
}






