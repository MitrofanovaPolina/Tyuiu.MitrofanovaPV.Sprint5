using Tyuiu.MitrofanovaPV.Sprint5.Task3.V1.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint5.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string nam = "OutPutFileTask3.bin";
            string p = Path.Combine(Path.GetTempPath(), nam);
            FileInfo fileInfo = new FileInfo(p);
            bool fileex = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
