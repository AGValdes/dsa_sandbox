using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class Queue<T>
  {
    public Node<T> Front { get; set; }
    public Node<T> Rear { get; set; }

    //-------------------Methods----------------------//
    public void Enqueue(T value)
    {
      Node<T> node = new Node<T>(value);
      if (Front == null)
      {
        Front = node; Rear = node;
      }
      Rear.Next = node;
      Rear = node;
    }

    public Node<T> Dequeue()
    {
      try
      {
        Node<T> oldFront = Front;
        Node<T> tempNode = Front.Next;

        Front = tempNode;
        return oldFront;


      }
      catch (NullReferenceException nre)
      {
        throw nre;
      }
    }

    public Node<T> Peek()
    {
      if (Front == null)
      {
        throw new NullReferenceException("There was nothing in queue!");
      }
      return Front;


    }

    public bool IsEmpty()
    {
      return Front == null;
    }


  }
}
