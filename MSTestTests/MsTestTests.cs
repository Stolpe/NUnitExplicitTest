using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests;

[TestClass]
public class MsTestTests
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.AreEqual("foo", "fo" + "o");
    }
}