using Tyuiu.MitrofanovaPV.Sprint5.Task4.V1.Lib;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();


        string nam = "InPutDataFileTask4V1.txt";
        string path = Path.Combine(Path.GetTempPath(), nam);
        double y = ds.LoadFromDataFile(path);
        
        Console.WriteLine(y);
        Console.ReadKey();
    }
}