using Tyuiu.MitrofanovaPV.Sprint5.Task4.V1.Lib;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();


        string nam = "InPutDataFileTask4V1.txt";
        string path = Path.Combine(Path.GetTempPath(), nam);
        double x = ds.LoadFromDataFile(path);
        double y = Math.Round(((1 / (Math.Cos(x) + x)) - 4.12 * x), 2);
        Console.WriteLine(y);
        Console.ReadKey();
    }
}