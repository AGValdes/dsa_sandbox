using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class LinkedList<T>
  {
    public Node<T> Head { get; set; }

    /// <summary>
    /// Plain, Empty Linked List
    /// Usage: LinkedLIst myLIst = new LinkedList();
    /// </summary>
    public LinkedList() { }

    /// <summary>
    /// Creates a linked list with a node, assigning Head
    /// Usage: LinkedList myList = new LinkedList(4);
    /// </summary>
    /// <param name="value"></param>
    public LinkedList(T value)
    {
      Node<T> node = new Node<T>(value);
      Head = node;
    }

    //-------------------------- METHODS--------------------------//

    public string toString()
    {

      Node<T> current = Head;
      string output = "";
      while (current != null)
      {
        Console.Write($"[{current.Value}] => ");
        output += $"[{current.Value}] => ";
        current = current.Next;

      }

      Console.WriteLine("NULL");
      output += "NULL";

      return output;
    }

    public string RecursiveToString(Node<T> node)
    {
      if (node == null)
      {
        Console.WriteLine("NULL");
        return "NULL";
      }

      Console.Write($"[{node.Value}] => ");
      RecursiveToString(node.Next);
      return node.Value.ToString();

    }

    public void Insert(T value)
    {
      // If we have a head ... do this
      // If not, make the node, and make it the head.
      Node<T> node = new Node<T>(value);
      node.Next = Head; // might be unnecessary if we don't have a head
      Head = node;
    }

    public static bool Includes(int value, LinkedList<T> myList)
    {
      //we need to traverse the linked list and compare each value to the argument
      //if the node value equals the argument, return true, otherwise continue tranversing until reaching null and return false
      Node<T> current = myList.Head;
      while (current != null)
      {
        if (current.Value.Equals(value))
        {
          return true;
        }
        current = current.Next;
      }

      return false;

    }

    public static void Append(LinkedList<T> myList, T newValue)
    {
      Node<T> current = myList.Head;

      Node<T> newNode = new Node<T>(newValue);
      while (current != null)
      {

        if (current.Next == null)
        {
          current.Next = newNode;

          break;

        }
        current = current.Next;
      }


    }
    public static void InsertBefore(LinkedList<T> myList, T value, T newValue)
    {
      Node<T> current = myList.Head;
      Node<T> newNode = new Node<T>(newValue);
      if (value.Equals(myList.Head.Value))
      {
        myList.Insert(newNode.Value);
      }
      else
      {

        while (current != null)
        {
          if (current.Next.Value.Equals(value))
          {
            newNode.Next = current.Next;
            current.Next = newNode;
            break;
          }
          current = current.Next;
        }
      }

    }

    public static void InsertAfter(LinkedList<T> myList, T value, T newValue)
    {
      Node<T> current = myList.Head;
      Node<T> newNode = new Node<T>(newValue);
      while (current != null)
      {
        if (current.Value.Equals(value))
        {
          newNode.Next = current.Next;
          current.Next = newNode;
        }

        current = current.Next;

      }
    }

    public static T KthFromEnd(LinkedList<T> myList, int k)
    {
      Node<T> current = myList.Head;
      int newArrLength = 0;
      T selectedValue = default(T);
      while (current != null)
      {
        current = current.Next;
        newArrLength++;
      }

      // check if value of n is not more than length of the linked list 
      if (newArrLength < k)
      {
        return default(T);

      }
      else if (newArrLength == k)
      {
        return myList.Head.Value;
      }

      current = myList.Head;

      // get the (len-k+1)th node from the beginning , this will be the kth node from the end
      for (int i = 1; i < newArrLength - k + 1; i++)
      {
        current = current.Next;
        selectedValue = current.Value;
        return selectedValue;

      }
      return selectedValue;
    }
  }
}
}
