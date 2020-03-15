using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MVCDevOpsDemo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expectedMsg = "test";
            Assert.AreEqual(expectedMsg, "test");
        }
    }
}
