using CustomString.Abstract;
using System;
using System.Text;
using System.Collections.Immutable;

namespace CustomString
{
  public class String : IStringPresenter
  {
    public char[] Contents { get; private set; }

    public int Length { get => Contents.Length; }

    public String()
    {
      Contents = new char[] { };
    }

    public String(string literal)
    {
      Contents = literal.ToCharArray();
    }

    public String(char symbol)
    {
      Contents = new char[] { symbol };
    }

    public String(char[] symbolArray)
    {
      Contents = symbolArray;
    }

    public void Clear()
    {
      Contents = new char[] { };
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      foreach (var item in Contents)
      {
        sb.Append(item);
      }
      return sb.ToString();
    }

    public char[] ValueAsCharArray() => Contents;

    public char this[int i]
    {
      get => Contents[i];
    }

    ~String()
    {
      Console.WriteLine("String Destructor");
      Contents = null;
    }
  }
}