using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MitrofanovaPV.Sprint5.Task3.V13.Lib
{
    public class DataService : ISprint5Task3V13
    {
        public string SaveToFileTextData(int x)
        {
            string nam = "OutPutFileTask3.bin";
            string p = Path.Combine(Path.GetTempPath(), nam);
            double y = (x)/(Math.Pow(x,3)+2);
            using (BinaryWriter writer = new BinaryWriter(File.Open(p, FileMode.OpenOrCreate),Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return p;
        }
    }
}
