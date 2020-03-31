using CustomString;
using NUnit.Framework;

namespace UnitTests
{
  public class TestString
  {
    [Test]
    public void TestToString()
    {
      String a = new String();
      String b = new String('b');
      String c = new String("Hello");
      String d = new String(new char[] { 'T', 'e', 's', 't' });
      Assert.AreEqual("", a.ToString());
      Assert.AreEqual("b", b.ToString());
      Assert.AreEqual("Hello", c.ToString());
      Assert.AreEqual("Test", d.ToString());
    }

    [Test]
    public void TestClear()
    {
      String a = new String();
      String b = new String('c');
      String c = new String("TEST");
      String d = new String(new char[] { 'T', 'e', 's', 't' });
      a.Clear();
      b.Clear();
      c.Clear();
      d.Clear();
      Assert.AreEqual("", a.ToString());
      Assert.AreEqual("", b.ToString());
      Assert.AreEqual("", c.ToString());
      Assert.AreEqual("", d.ToString());
    }
  }
}