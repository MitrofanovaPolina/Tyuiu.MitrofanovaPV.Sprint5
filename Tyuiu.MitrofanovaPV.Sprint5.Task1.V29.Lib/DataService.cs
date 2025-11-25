using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MitrofanovaPV.Sprint5.Task1.V29.Lib
{
    public class DataService : ISprint5Task1V29
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string nam = "OutPutFileTask1.txt";
            string p = Path.Combine(Path.GetTempPath(), nam);
            FileInfo fileInfo = new FileInfo(p);
            bool fileex = fileInfo.Exists;
            if (fileex)
            {
                File.Delete(p);

            }
            double y;
            string stry;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = (((Math.Sin(x))/(x+1.2)) + Math.Cos(x)*7*x -2);
                stry = Convert.ToString(y);
                if (x!=stopValue)
                {
                    File.AppendAllText(p, stry + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(p, stry);
                }
            }
            return p;
        }
    }
}
