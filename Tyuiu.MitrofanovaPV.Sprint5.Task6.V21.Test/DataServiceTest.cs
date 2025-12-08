using Tyuiu.MitrofanovaPV.Sprint5.Task6.V21.Lib;

namespace Tyuiu.MitrofanovaPV.Sprint5.Task6.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string d = "C:\\nn\\";
            string nam = "InPutDataFileTask6V21.txt";
            string p = Path.Combine(d, nam);
            FileInfo fileInfo = new FileInfo(p);
            bool fileex = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
        

    }
}
