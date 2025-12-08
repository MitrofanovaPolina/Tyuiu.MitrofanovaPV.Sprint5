using Tyuiu.MitrofanovaPV.Sprint5.Task7.V2.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint5.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string d = "C:\\nn\\";
            string nam = "OutPutDataFileTask7V2.txt";
            string p = Path.Combine(d, nam);
            FileInfo fileInfo = new FileInfo(p);
            bool fileex = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
