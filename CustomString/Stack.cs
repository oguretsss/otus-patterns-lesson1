using CustomString.Abstract;
using System;

namespace CustomString
{
  public class Stack<T> where T : IStringPresenter
  {
    public int Size { get; private set; }
    private const int DEFAULT_CAPACITY = 16;
    private const float EXPAND_PART = 0.5f;
    private const int EXPAND_MULTIPLIER = 2;
    private T[] elements;

    public Stack()
    {
      elements = new T[DEFAULT_CAPACITY];
      Size = 0;
    }

    public Stack(int initialCapacity)
    {
      elements = new T[initialCapacity];
      Size = 0;
    }

    public T Pop()
    {
      if (Size == 0)
      {
        throw new InvalidOperationException("Stack is empty");
      }
      else
      {
        var value = elements[Size - 1];
        elements[Size - 1] = default;
        Size--;
        return value;
      }
    }

    public void Push(T element)
    {
      if (Size > elements.Length * EXPAND_PART)
      {
        T[] expandedStack = new T[elements.Length * EXPAND_MULTIPLIER];
        elements.CopyTo(expandedStack, 0);
        elements = expandedStack;
      }
      elements[Size] = element;
      Size++;
    }

    public T Peek()
    {
      if (Size == 0)
      {
        throw new InvalidOperationException("Stack is empty");
      }
      else
      {
        return elements[Size - 1];
      }
    }

    public T this[int i]
    {
      get
      {
        if (i >= Size)
        {
          throw new IndexOutOfRangeException();
        }
        return elements[i];
      }
    }

    public int isEmpty()
    {
      return Size == 0 ? 1 : 0;
    }

    public void ViewContents()
    {
      for (int i = Size - 1; i >= 0; i--)
      {
        Console.WriteLine(elements[i].ToString());
      }
    }
  }
}