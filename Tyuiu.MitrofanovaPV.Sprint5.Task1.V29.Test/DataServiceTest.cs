using Tyuiu.MitrofanovaPV.Sprint5.Task1.V29.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint5.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string nam = "OutPutFileTask1.txt";
            string p = Path.Combine(Path.GetTempPath(), nam);
            FileInfo fileInfo = new FileInfo(p);
            bool fileex = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
