namespace Tyuiu.MitrofanovaPV.Sprint5.Task5.V30.Test
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
}
