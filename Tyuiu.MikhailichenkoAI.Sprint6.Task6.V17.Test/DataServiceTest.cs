using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MikhailichenkoAI.Sprint6.Task6.V17.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint6.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutFileTask6V17.txt");
            File.WriteAllText(path, "One Two Three Four\nFive Six Seven Eight");
            string res = ds.CollectTextFromFile(path);
            string wait = "Three Seven";
            Assert.AreEqual(wait, res);
        }
    }
}
