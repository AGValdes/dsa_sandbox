using System;
using System.Text;
using Xunit;
using DataStructures;

namespace DataStructure_Tests
{
  public class StacksTests
  {
    [Fact]

    public void Test_For_Successful_Push_Onto_Stack()
    {
      Stack<int> testStack = new Stack<int>();
      testStack.Push(1);

      Assert.True(testStack.isEmpty());
    }

    [Fact]

    public void Test_For_Multiple_Pushes()
    {
      Stack<int> testStack = new Stack<int>();
      testStack.Push(1);
      testStack.Push(2);
      testStack.Push(3);

      Assert.NotNull(testStack.top.Next);
    }

    [Fact]
    public void Can_Pop_Off()
    {
      Stack<int> testStack = new Stack<int>();
      testStack.Push(1);
      testStack.Pop();

      Assert.Null(testStack.top);

    }
    [Fact]
    public void Can_Empty_The_Stack()
    {
      Stack<int> testStack = new Stack<int>();
      testStack.Push(1);
      testStack.Push(2);
      testStack.Push(3);
      testStack.Pop();
      testStack.Pop();
      testStack.Pop();

      Assert.Null(testStack.top);
    }

    [Fact]
    public void Can_Peek_Next_Item()
    {
      Stack<int> testStack = new Stack<int>();
      testStack.Push(2);
      testStack.Push(1);
      Node<int> result = testStack.Peek().Next;

      Assert.Equal(2, result.Value);
    }

    [Fact]

    public void Can_Instantiate_Empty_Stack()
    {

      Stack<int> testStack = new Stack<int>();

      Assert.Null(testStack.top);
    }

    [Fact]

    public void Pop_Throws_Excpetion_For_Empty_Stack()
    {
      Stack<int> testStack = new Stack<int>();

      Assert.Null(testStack.Pop());


    }
  }
}
