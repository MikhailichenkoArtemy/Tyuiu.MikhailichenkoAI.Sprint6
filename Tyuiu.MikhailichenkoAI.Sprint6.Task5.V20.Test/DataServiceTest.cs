using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MikhailichenkoAI.Sprint6.Task5.V20.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint6.Task5.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutFileTask5V20.txt");
            File.WriteAllText(path, "16\n-12\n5");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
