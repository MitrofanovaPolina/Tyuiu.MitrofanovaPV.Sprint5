using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MitrofanovaPV.Sprint5.Task0.V24.Lib
{
    public class DataService : ISprint5Task0V24
    {
        public string SaveToFileTextData(int x)
        {
            string nam = "OutPutFileTask0.txt";
            string p = Path.Combine(Path.GetTempPath(), nam);
            double y = (Math.Pow(x, 3) - 8) / (2 * (Math.Pow(x, 3)));
            y = Math.Pow(y, 3);
            File.WriteAllText(p, Convert.ToString(y));
            return p;
        }
    }
}
