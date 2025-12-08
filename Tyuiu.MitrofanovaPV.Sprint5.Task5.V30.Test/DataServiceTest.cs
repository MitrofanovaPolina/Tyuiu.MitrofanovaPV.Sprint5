namespace Tyuiu.MitrofanovaPV.Sprint5.Task5.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string d = "C:\\nn\\";
            string nam = "InPutDataFileTask5V30.txt";
            string p = Path.Combine(d, nam);
            FileInfo fileInfo = new FileInfo(p);
            bool fileex = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    
    }
}
