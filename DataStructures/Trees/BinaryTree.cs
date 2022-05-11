using System;
using System.Collections.Generic;

namespace DataStructures
{
  public class BinaryTree<T> where T : IComparable
  {
    public Node<T> Root { get; set; }

    public List<T> Values { get; set; }

    //-------------------Methods----------------------//
    public void Add(Node<T> node, T value)
    {
      Node<T> newNode = new Node<T>(value);

      if (Root == null)
      {
        Root = newNode;
        return;
      }

      if (node.Left == null) { node.Left = newNode; }
      else { Add(node.Left, value); }

      if (node.Right == null) { node.Right = newNode; }
      else { Add(node.Right, value); }

    }
    public List<T> PreOrder(Node<T> node, List<T> values)
    {
      values.Add(node.Value);
      if (node.Left != null) { PreOrder(node.Left, values); }
      if (node.Right != null) { PreOrder(node.Right, values); }
      return values;
    }

    public List<T> InOrder(Node<T> node, List<T> values)
    {
      if (node.Left != null) { InOrder(node.Left, values); }
      values.Add(node.Value);
      if (node.Right != null) { InOrder(node.Right, values); }
      return values;
    }

    public List<T> PostOrder(Node<T> node, List<T> values)
    {

      if (node.Left != null) { PostOrder(node.Left, values); }
      if (node.Right != null) { PostOrder(node.Right, values); }
      values.Add(node.Value);
      return values;
    }

    public List<T> BreadthFirstTraversal()
    {
      List<T> values = new List<T>();

      Queue<Node<T>> nodes = new Queue<Node<T>>();

      nodes.Enqueue(Root);

      while (nodes.Peek() != null)
      {

        Node<Node<T>> nodeNode = nodes.Dequeue();
        Node<T> node = nodeNode.Value;

        values.Add(node.Value);
        if (node.Left != null) { nodes.Enqueue(node.Left); }
        if (node.Right != null) { nodes.Enqueue(node.Right); }
      }
      return values;

    }

    public T FindMaximumValue(Node<T> node, T largestSoFar)
    {

      if (node.Value.CompareTo(largestSoFar) > 0)
      {
        largestSoFar = node.Value;
      }
      if (node.Left != null) { FindMaximumValue(node.Left, largestSoFar); }
      if (node.Right != null) { FindMaximumValue(node.Right, largestSoFar); }

      return largestSoFar;
    }


  }
}
