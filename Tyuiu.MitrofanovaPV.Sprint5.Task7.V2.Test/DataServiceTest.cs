using Tyuiu.MitrofanovaPV.Sprint5.Task7.V2.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint5.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string save = "C:/DataSprint5/InPutDataFileTask7V2.txt";
            FileInfo fileInfo = new FileInfo(save);
            bool fileex = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
        
    }
}
