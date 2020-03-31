using System;

namespace CustomString
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      var a = "Hello";
      Console.WriteLine(a);
      string b = a.Substring(5);
      Console.WriteLine(b);
      string c = a.Substring(1, 0);
      Console.WriteLine(c);
    }
  }
}