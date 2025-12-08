using Tyuiu.MitrofanovaPV.Sprint5.Task7.V2.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint5.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string di = "C:\\DataSprint5\\";
            string namm = "OutPutDataFileTask7V2.txt";
            string save = Path.Combine(di, namm);
            FileInfo fileInfo = new FileInfo(save);
            bool fileex = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string dii = "C:\\DataSprint5\\";
            string nham = "InPutDataFileTask7V2.txt";
            string path = Path.Combine(dii, nham);
            FileInfo fileInfo = new FileInfo(path);
            bool fileex = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
