using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class Stack<T>
  {
    public Node<T> top { get; set; }

    //-------------------Methods----------------------//

    public bool isEmpty()
    {
      return top != null;
    }

    public void Push(T value)
    {
      Node<T> node = new Node<T>(value);
      node.Next = top;
      top = node;
    }

    public Node<T> Pop()
    {
      try
      {
        Node<T> currentTop = top;
        top = currentTop.Next;
        return currentTop;
      }
      catch
      {
        return null;
      }
    }

    public Node<T> Peek()
    {

      return top;

    }
  }
}
