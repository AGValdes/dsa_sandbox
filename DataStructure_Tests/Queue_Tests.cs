using System;
using System.Text;
using Xunit;
using DataStructures;

namespace DataStructure_Tests
{
  public class QueuesTests
  {
    [Fact]

    public void Can_Enqueue()
    {
      Queue<int> testQueue = new Queue<int>();

      testQueue.Enqueue(1);
      Node<int> testNode = new Node<int>(1);

      Assert.Equal(1, testQueue.Front.Value);
    }
    [Fact]
    public void Enqueue_Multiple_Nodes_To_Queue()
    {
      Queue<int> queue = new Queue<int>();
      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);
      Assert.Equal(3, queue.Rear.Value);
    }
    /// <summary>
    /// Dequeue a node from the Queue.  Front should change to next item in Queue
    /// </summary>
    [Fact]
    public void Dequeue_Node_From_Queue()
    {
      Queue<int> queue = new Queue<int>();
      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);
      queue.Enqueue(4);
      queue.Enqueue(5);
      queue.Dequeue();
      queue.Dequeue();

      Assert.Equal(3, queue.Front.Value);
    }
    /// <summary>
    /// Able to peek at the correct node that is at the Front of the Queue
    /// </summary>
    [Fact]
    public void Peek_At_Front_Node_In_Queue()
    {
      Queue<int> queue = new Queue<int>();
      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);
      Assert.Equal(1, queue.Peek().Value);
    }
    /// <summary>
    /// Able to empty the queue and isEmpty return a True value and Front should be null
    /// </summary>
    [Fact]
    public void Empty_A_Queue()
    {
      Queue<int> queue = new Queue<int>();
      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);
      queue.Dequeue();
      queue.Dequeue();
      queue.Dequeue();

      Assert.True(queue.IsEmpty());
      Assert.Null(queue.Front);
    }
    /// <summary>
    /// Able to create an empty queue, with no nodes
    /// </summary>
    [Fact]
    public void Instantiate_An_Empty_Queue()
    {
      Queue<int> queue = new Queue<int>();
      Assert.Null(queue.Front);
    }
    [Fact]
    public void Peek_On_An_Empty_Queue_Raises_Null_Excpetion()
    {
      Queue<int> queue = new Queue<int>();
      Assert.Throws<NullReferenceException>(() => queue.Peek());
    }
  }
}
