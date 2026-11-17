using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MikhailichenkoAI.Sprint6.Task7.V17.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint6.Task7.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutFileTask7V17.csv");
            File.WriteAllText(path, "1;2;3\n4;5;6\n7;8;9"); 

            DataService ds = new DataService();
            int[,] res = ds.GetMatrix(path);
            int[,] wait = { { 1, 2, 3 }, { 4, 5, 4 }, { 7, 8, 9 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
