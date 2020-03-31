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
      StringUtil util = new StringUtil(new String("Test"));
      Assert.AreEqual("est", util.SubString(1).ToString());
      Assert.AreEqual("", util.SubString(4).ToString());
      Assert.Throws<ArgumentOutOfRangeException>(() => util.SubString(-1));
      Assert.Throws<ArgumentOutOfRangeException>(() => util.SubString(5));
    }

    [Test]
    public void TestSubStringTwoParams()
    {
      StringUtil util = new StringUtil(new String("Test"));
      Assert.AreEqual("es", util.SubString(1, 2).ToString());
      Assert.Throws<ArgumentOutOfRangeException>(() => util.SubString(-1, 3));
      Assert.Throws<ArgumentOutOfRangeException>(() => util.SubString(5, 3));
      Assert.Throws<ArgumentOutOfRangeException>(() => util.SubString(1, 6));
      Assert.Throws<ArgumentOutOfRangeException>(() => util.SubString(1, -1));
    }
  }
}