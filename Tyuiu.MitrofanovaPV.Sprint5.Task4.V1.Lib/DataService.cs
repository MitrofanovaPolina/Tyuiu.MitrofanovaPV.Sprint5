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
            double x = double.Parse(strx.Replace(",","."),System.Globalization.CultureInfo.InvariantCulture);
            double y = Math.Round(((1 / (Math.Cos(x) + x)) - 4.12 * x), 2);
            return y;
        }
    }
}
