using Tyuiu.MitrofanovaPV.Sprint5.Task7.V2.Lib;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        string dii = "C:\\DataSprint5\\";
        string nham = "InPutDataFileTask7V2.txt";
        string path = Path.Combine(dii, nham);
        string di = "C:\\DataSprint5\\";
        string namm = "OutPutDataFileTask7V2.txt";
        string save = Path.Combine(di, namm);
        save = ds.LoadDataAndSave(path);
        Console.WriteLine(save);
        Console.ReadKey();
    }
}