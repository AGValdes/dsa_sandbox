using System;
using Xunit;
using DataStructures;

namespace DataStructure_Tests
{
	public class UnitTest1
	{
    [Fact]
    public void Linked_List_Created_With_A_Value_Has_Correct_Head()
    {
      int value = 2;

      LinkedList<int> testList = new LinkedList<int>(value);

      Assert.Equal(testList.Head.Value, value);

    }

    [Fact]
    public void After_Insert_New_Node_Is_Head()
    {
      LinkedList<int> testList = new LinkedList<int>(1);
      // H(2) -> (1)
      testList.Insert(2);

      Assert.Equal(2, testList.Head.Value);
    }

    [Fact]
    public void After_Insert_New_Head_Next_is_Old_Head()
    {
      // H(1)
      LinkedList<int> testList = new LinkedList<int>(1);
      Node<int> oldHead = testList.Head;

      // H(2) -> (1)
      testList.Insert(2);

      Assert.Equal(oldHead, testList.Head.Next);

    }
    //this test checks if our include method finds the given value in a linked list
    [Fact]
    public void Confirm_Include_Works_With_Value_That_Is_In_List()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(1);
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);
      testList.Insert(5);
      testList.Insert(6);

      int testValue = 4;

      bool result = LinkedList<int>.Includes(testValue, testList);

      Assert.True(result);


    }
    //This checks that we will get a false return when the given value does not exist in the linked list
    [Fact]
    public void Confirm_Include_Works_With_Value_That_Is_Not_In_List()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(1);
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);
      testList.Insert(5);
      testList.Insert(6);

      int testValue = 27;

      bool result = LinkedList<int>.Includes(testValue, testList);

      Assert.False(result);


    }
    //This will test that multiple nodes can be inserted
    [Fact]
    public void Can_Multiple_Nodes_Be_Inserted()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(1);
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);
      Node<int> current = testList.Head;
      int counter = 0;


      while (current != null)
      {
        counter++;
        current = current.Next;
      }

      Assert.Equal(4, counter);

    }
    //This tests if the toString method returns the collection of values in the list
    [Fact]
    public void Properly_Returns_Values()
    {
      LinkedList<int> testList = new LinkedList<int>(42);
      testList.Insert(96);
      testList.Insert(72);

      string test = "[72] => [96] => [42] => NULL";



      Assert.Equal(test, testList.toString());


    }
    /// <summary>
    ///tests to see if we can make an empty linked list
    /// </summary>
    [Fact]
    public void Can_Make_Empty()
    {
      LinkedList<int> testList = new LinkedList<int>();

      Assert.Null(testList.Head);
    }
    /// <summary>
    ///The below test checks that the Append method
    ///makes a new node at the end of a linked list,
    ///meaning it created a new tail
    /// </summary>
    [Fact]
    public void Append_Makes_New_Node_At_End()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(1);
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);

      LinkedList<int>.Append(testList, 5);

      Assert.Equal(5, testList.Head.Next.Next.Next.Next.Value);

    }
    /// <summary>
    ///the below test checks if the Append method can create
    ///multiple nodes at the end of a Linked List
    /// </summary>
    [Fact]
    public void Append_Makes_Multiple_New_Nodes_At_End()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(1);
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);

      LinkedList<int>.Append(testList, 5);
      LinkedList<int>.Append(testList, 6);


      Assert.Equal(5, testList.Head.Next.Next.Next.Next.Value);
      Assert.Equal(6, testList.Head.Next.Next.Next.Next.Next.Value);

    }
    /// <summary>
    ///the below test checks that the insertBefore method makes a new node
    ///with a value of the second parameter before the node with the value of
    ///the first parameter
    /// </summary>
    [Fact]
    public void Insert_Before_Makes_New_Node_With_Given_Value_Before_Node_With_Given_Value()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(1);
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);

      LinkedList<int>.InsertBefore(testList, 3, 5);

      Assert.Equal(5, testList.Head.Next.Value);

    }
    /// <summary>
    /// the below test checks that the insertBefore method will
    /// create a new head if it is instructed to put a new node before
    /// the first item of the list
    /// </summary>
    [Fact]
    public void Insert_Before_First_Node()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(1);
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);

      LinkedList<int>.InsertBefore(testList, 4, 5);

      Assert.Equal(5, testList.Head.Value);

    }

    /// <summary>
    /// the below test checks if the insertAfter method inserts a new node
    /// with the value of the 2nd parameter after the node with a value of
    /// the second parameter
    /// </summary>
    [Fact]
    public void Insert_After_Makes_New_Node_With_Given_Value_After_Node_With_Given_Value()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(1);
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);

      LinkedList<int>.InsertAfter(testList, 3, 5);

      Assert.Equal(5, testList.Head.Next.Next.Value);

    }
    /// <summary>
    ///The below test checks that the insertAfter method
    ///creates a node at the end of the list, or creates a new tail
    /// </summary>
    [Fact]
    public void Insert_After_Makes_New_Node_At_End()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(1);
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);

      LinkedList<int>.InsertAfter(testList, 1, 5);

      Assert.Equal(5, testList.Head.Next.Next.Next.Next.Value);

    }
    /// <summary>
    /// This test checks that kth from end function will return
    /// 0 if k is greater than the length of the Linked List
    /// </summary>
    [Fact]

    public void K_Is_Greater_Than_List_Length()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(5);
      testList.Insert(4);
      testList.Insert(3);
      testList.Insert(2);
      testList.Insert(1);

      int result = LinkedList<int>.KthFromEnd(testList, 6);

      Assert.Equal(0, result);
    }
    /// <summary>
    /// Test below choecks that kth from end method will return
    /// the head if k is equal to the length of the list
    /// </summary>
    [Fact]

    public void K_Is_Equal_To_List_Length()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(5);
      testList.Insert(4);
      testList.Insert(3);
      testList.Insert(2);
      testList.Insert(1);

      int result = LinkedList<int>.KthFromEnd(testList, 5);

      Assert.Equal(1, result);
    }
    /// <summary>
    /// Test below checks that given a negative number for k, it will return
    /// the value of the node that distance from the front instead of the end
    /// </summary>
    [Fact]

    public void K_Is_Negative()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(5);
      testList.Insert(4);
      testList.Insert(3);
      testList.Insert(2);
      testList.Insert(1);

      int result = LinkedList<int>.KthFromEnd(testList, -2);

      Assert.Equal(2, result);
    }
    /// <summary>
    ///The below test checks that the kthFromEnd method
    ///will return the only node value if the list only has a length of 1
    ///and k is 1
    /// </summary>
    [Fact]

    public void List_Has_Length_Of_One()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(5);

      int result = LinkedList<int>.KthFromEnd(testList, 1);

      Assert.Equal(5, result);
    }
    /// <summary>
    ///the below test checks that kthFromEnd returns
    ///the value of the node that is a distance of k
    ///away from the end of the list
    /// </summary>
    [Fact]

    public void K_Is_In_The_Middle_Of_The_List_AKA_Happy_Path()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(5);
      testList.Insert(4);
      testList.Insert(3);
      testList.Insert(2);
      testList.Insert(1);

      int result = LinkedList<int>.KthFromEnd(testList, 3);

      Assert.Equal(2, result);
    }
  }
}
