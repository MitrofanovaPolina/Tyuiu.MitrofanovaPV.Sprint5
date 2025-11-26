using Tyuiu.MitrofanovaPV.Sprint5.Task4.V1.Lib;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        

        string path = @"C:\DataSprint5\InPutDataFileTask4V1.txt";
        double x = ds.LoadFromDataFile(path);
        double y = (1 / (Math.Cos(x) + x)) - 4.12 * x;
        Console.WriteLine(y);
        Console.ReadKey();
    }
}