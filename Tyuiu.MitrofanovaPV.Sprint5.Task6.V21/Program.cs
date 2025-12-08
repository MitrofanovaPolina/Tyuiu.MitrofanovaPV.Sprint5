using Tyuiu.MitrofanovaPV.Sprint5.Task6.V21.Lib;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\nn\InPutDataFileTask6V21.txt";
        DataService ds = new DataService();
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}