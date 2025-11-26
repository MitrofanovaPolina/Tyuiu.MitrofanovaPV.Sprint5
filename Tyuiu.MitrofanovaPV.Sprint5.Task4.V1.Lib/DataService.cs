using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MitrofanovaPV.Sprint5.Task4.V1.Lib
{
    public class DataService : ISprint5Task4V1
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            double res = double.Parse(strx.Replace(",","."),System.Globalization.CultureInfo.InvariantCulture);
            return res;
        }
    }
}
