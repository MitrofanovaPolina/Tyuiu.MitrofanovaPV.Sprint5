using Tyuiu.MitrofanovaPV.Sprint5.Task5.V30.Lib;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();



        string path = @"C:\nn\InPutDataFileTask5V30.txt";
        double y = ds.LoadFromDataFile(path);

        Console.WriteLine(y);
        Console.ReadKey();
    }
}