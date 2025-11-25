using Tyuiu.MitrofanovaPV.Sprint5.Task0.V24.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint5.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string nam = "OutPutFileTask0.txt";
            string p = Path.Combine(Path.GetTempPath(), nam);
            FileInfo fileInfo = new FileInfo(p);
            bool fileex = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
            
        }
    }
}
