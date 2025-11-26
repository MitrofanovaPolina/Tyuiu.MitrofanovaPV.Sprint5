using Tyuiu.MitrofanovaPV.Sprint5.Task4.V1.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint5.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string nam = @"C:\DataSprint5\InPutDataFileTask4V1.txt";
            
            FileInfo fileInfo = new FileInfo(nam);
            bool fileex = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
