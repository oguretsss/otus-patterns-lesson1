using System;
using CustomString;
using NUnit.Framework;
using String = CustomString.String; // to avoid name conflicts with System.String

namespace UnitTests
{
  [TestFixture]
  internal class TestStringUtil
  {
    [Test]
    public void TestSubStringOneParam()
    {
      /// <summary>
      /// Create StringUtil object, call substring method with one param
      /// check that it works correctly
      /// Check that method throws expection in case of incorrect arguments
      /// </summary>
      StringUtil util = new StringUtil(new String("Test"));
      Assert.AreEqual("est", util.SubString(1).ToString());
      Assert.AreEqual("", util.SubString(4).ToString());
      Assert.Throws<ArgumentOutOfRangeException>(() => util.SubString(-1));
      Assert.Throws<ArgumentOutOfRangeException>(() => util.SubString(5));
      Assert.AreEqual("Test", util.ToString());
    }

    [Test]
    public void TestSubStringTwoParams()
    {
      /// <summary>
      /// Create StringUtil object, call substring method with two params
      /// check that it works correctly
      /// Check that method throws expection in case of incorrect arguments
      /// </summary>
      StringUtil util = new StringUtil(new String("Test"));
      Assert.AreEqual("es", util.SubString(1, 2).ToString());
      Assert.Throws<ArgumentOutOfRangeException>(() => util.SubString(-1, 3));
      Assert.Throws<ArgumentOutOfRangeException>(() => util.SubString(5, 3));
      Assert.Throws<ArgumentOutOfRangeException>(() => util.SubString(1, 6));
      Assert.Throws<ArgumentOutOfRangeException>(() => util.SubString(1, -1));
      Assert.AreEqual("Test", util.ToString());
    }

    [Test]
    public void TestIStringPresenterImplementation()
    {
      /// <summary>
      /// Create string util object, check that it returns correct char array
      /// via ValueAsCharArray() method
      /// </summary>
      StringUtil util = new StringUtil(new String("Test"));
      char[] contents = util.ValueAsCharArray();
      Assert.AreEqual('T', contents[0]);
      Assert.AreEqual('e', contents[1]);
      Assert.AreEqual('s', contents[2]);
      Assert.AreEqual('t', contents[3]);

      //Call SubString() method, check that contents remained the same
      util.SubString(1);
      contents = util.ValueAsCharArray();
      Assert.AreEqual('T', contents[0]);
      Assert.AreEqual('e', contents[1]);
      Assert.AreEqual('s', contents[2]);
      Assert.AreEqual('t', contents[3]);
    }
  }
}