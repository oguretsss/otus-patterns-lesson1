using CustomString.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomString
{
  public class StringUtil : IStringPresenter
  {
    private String target;

    public int Length => target.Length;

    public StringUtil(String target)
    {
      this.target = target;
    }

    public String SubString(int startIndex)
    {
      if (startIndex < 0 || startIndex > target.Length)
      {
        throw new ArgumentOutOfRangeException("Start index should be more than zero " +
                                              "and less than or equal to string length");
      }

      char[] substr = new char[target.Length - startIndex];
      for (int i = 0; i < substr.Length; i++)
      {
        substr[i] = target[i + startIndex];
      }
      return new String(substr);
    }

    public String SubString(int startIndex, int length)
    {
      if (startIndex < 0 || startIndex > target.Length)
      {
        throw new ArgumentOutOfRangeException("Start index should be more than zero " +
                                              "and less than or equal to string length");
      }
      if (length < 0)
      {
        throw new ArgumentOutOfRangeException("Length cannot be less than zero");
      }

      if (startIndex + length > target.Length)
      {
        throw new ArgumentOutOfRangeException("Start index and length must refer to a location within string");
      }

      char[] substr = new char[length];
      for (int i = 0; i < substr.Length; i++)
      {
        substr[i] = target[startIndex + i];
      }
      return new String(substr);
    }

    public char[] ValueAsCharArray() => target.Contents;

    public override string ToString()
    {
      return target.ToString();
    }
  }
}