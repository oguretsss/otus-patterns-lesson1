using CustomString;
using NUnit.Framework;

namespace UnitTests
{
  public class TestString
  {
    [Test]
    public void TestToString()
    {
      /// <summary>
      /// Create different String objects, check that they al are returned as strings correctly
      /// </summary>
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
      /// <summary>
      /// Create several String objects, call Clear() method, check that all of them are empty
      /// </summary>
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

    [Test]
    public void TestIStringPresenterImplementation()
    {
      /// <summary>
      /// Create string util object, check that it returns correct char array
      /// via ValueAsCharArray() method
      /// </summary>
      String a = new String("Test");
      char[] contents = a.ValueAsCharArray();
      Assert.AreEqual('T', contents[0]);
      Assert.AreEqual('e', contents[1]);
      Assert.AreEqual('s', contents[2]);
      Assert.AreEqual('t', contents[3]);

      String b = new String();
      contents = b.ValueAsCharArray();
      Assert.AreEqual(0, contents.Length);

      String d = new String(new char[] { 'T', 'e', 's', 't' });
      contents = d.ValueAsCharArray();
      Assert.AreEqual('T', contents[0]);
      Assert.AreEqual('e', contents[1]);
      Assert.AreEqual('s', contents[2]);
      Assert.AreEqual('t', contents[3]);
    }
  }
}