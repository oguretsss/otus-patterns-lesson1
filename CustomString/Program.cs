using CustomString.Abstract;
using System;

namespace CustomString
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("Creating a stack");
      Stack<IStringPresenter> stack = new Stack<IStringPresenter>();

      String a = new String(new char[] { 'T', 'h', 'i', 's', ' ', 'i', 's', ' ', 'a', ' ', 's', 't', 'r', 'i', 'n', 'g', '!' });
      StringUtil aModifier = new StringUtil(a);
      stack.Push(a);
      Console.WriteLine($"First Object in stack: {stack.Peek()} of type {stack.Peek().GetType()}");
      stack.Push(aModifier.SubString(10));   // string!
      stack.Push(aModifier.SubString(8, 1)); // a
      stack.Push(aModifier.SubString(5, 2)); // is
      stack.Push(aModifier.SubString(0, 4)); // This
      stack.Push(aModifier);
      Console.WriteLine($"Top Object in stack: {stack.Peek()} of type {stack.Peek().GetType()}");
      Console.WriteLine("Full stack conetnt:\n");
      /// Show stack contents
      stack.ViewContents();
    }
  }
}