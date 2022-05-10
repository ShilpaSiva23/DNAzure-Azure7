using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace TestProjectwithJenkins
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World from Shilpa";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                JenkinsTest.Program.Main();

                string? result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}