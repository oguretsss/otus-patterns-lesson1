using CustomString;
using CustomString.Abstract;
using NUnit.Framework;
using System;
using String = CustomString.String;

namespace UnitTests
{
  public class TestStack
  {
    [Test]
    public void TestPop()
    {
      /// <summary>
      /// Create stack, add oject, call Pop() method, check that it returned correct result
      /// call Pop() again, expect to get Exception
      /// </summary>
      Stack<IStringPresenter> stack = new Stack<IStringPresenter>();
      stack.Push(new String("Test"));
      Assert.AreEqual("Test", stack.Pop().ToString());
      Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }

    [Test]
    public void TestPopCorrectOrder()
    {
      /// <summary>
      /// Check that Pop method actually returns objects First In First Out
      /// </summary>
      Stack<IStringPresenter> stack = new Stack<IStringPresenter>();
      stack.Push(new String("Test"));
      stack.Push(new String("Test2"));
      stack.Push(new String("Test3"));
      Assert.AreEqual("Test3", stack.Pop().ToString());
      Assert.AreEqual("Test2", stack.Pop().ToString());
      Assert.AreEqual("Test", stack.Pop().ToString());
      Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }

    [Test]
    public void TestPush()
    {
      /// <summary>
      /// Create stack, add oject, check stack size
      /// add one more object, chack stack size
      /// </summary>
      Stack<IStringPresenter> stack = new Stack<IStringPresenter>();
      stack.Push(new String("Test"));
      Assert.AreEqual(1, stack.Size);
      stack.Push(new String("Test2"));
      Assert.AreEqual(2, stack.Size);
    }

    [Test]
    public void TestStackExpand()
    {
      /// <summary>
      /// Create stack with size 1, add object, check stack size
      /// add one more object, check stack size, expect no errors
      /// </summary>
      Stack<IStringPresenter> stack = new Stack<IStringPresenter>(1);
      stack.Push(new String("Test"));
      Assert.AreEqual(1, stack.Size);
      Assert.AreEqual("Test", stack.Peek().ToString());
      stack.Push(new String("Test2"));
      Assert.AreEqual(2, stack.Size);
      Assert.AreEqual("Test2", stack.Peek().ToString());
    }

    [Test]
    public void TestFIFOLogic()
    {
      /// <summary>
      /// Create stack, add and delete objects in different order
      /// check that stack works as expected
      /// </summary>
      Stack<IStringPresenter> stack = new Stack<IStringPresenter>();
      stack.Push(new String("Test"));
      stack.Push(new String("Test2"));
      stack.Push(new String("Test3"));
      Assert.AreEqual(3, stack.Size);
      Assert.AreEqual("Test3", stack.Pop().ToString());
      Assert.AreEqual("Test2", stack.Pop().ToString());
      stack.Push(new String("Test4"));
      stack.Push(new String("Test5"));
      Assert.AreEqual("Test5", stack.Pop().ToString());
      Assert.AreEqual("Test4", stack.Pop().ToString());
      Assert.AreEqual("Test", stack.Pop().ToString());
    }

    [Test]
    public void TestPeek()
    {
      /// <summary>
      /// Create stack, add object to stack, call Peek()
      /// check that stack size remained the same
      /// </summary>
      Stack<IStringPresenter> stack = new Stack<IStringPresenter>();
      stack.Push(new String("Test"));
      Assert.AreEqual(1, stack.Size);
      Assert.AreEqual("Test", stack.Peek().ToString());
      Assert.AreEqual(1, stack.Size);
    }

    [Test]
    public void TestIsEmpty()
    {
      /// <summary>
      /// Create stack, check that it's empty
      /// add object to stack, check that stack's not empty
      /// remove object from stack, check that stack is empty
      /// </summary>
      Stack<IStringPresenter> stack = new Stack<IStringPresenter>();
      Assert.AreEqual(1, stack.isEmpty());
      stack.Push(new String("Test"));
      Assert.AreEqual(0, stack.isEmpty());
      stack.Peek();
      Assert.AreEqual(0, stack.isEmpty());
      stack.Pop();
      Assert.AreEqual(1, stack.isEmpty());
    }
  }
}