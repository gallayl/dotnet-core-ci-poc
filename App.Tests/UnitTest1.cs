using Microsoft.VisualStudio.TestTools.UnitTesting;
using App;

namespace App.Tests
{
    [TestClass]
    public class CallMainMethod
    {
        [TestMethod]
        public void TestProgramMain()
        {
            Program.Main();
        }

        [TestMethod]
        public void TestProgramAdd()
        {
            Assert.AreEqual(Program.Add(1,2), 3);
        }
    }
}
