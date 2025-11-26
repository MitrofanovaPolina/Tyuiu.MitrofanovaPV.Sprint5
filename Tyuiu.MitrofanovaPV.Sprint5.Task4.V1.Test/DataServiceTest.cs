using Tyuiu.MitrofanovaPV.Sprint5.Task4.V1.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint5.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string nam = "InPutDataFileTask4V1.txt";
            string p = Path.Combine(Path.GetTempPath(), nam);
            FileInfo fileInfo = new FileInfo(nam);
            bool fileex = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
