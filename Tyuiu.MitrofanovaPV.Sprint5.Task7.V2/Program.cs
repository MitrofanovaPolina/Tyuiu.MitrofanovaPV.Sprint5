using Tyuiu.MitrofanovaPV.Sprint5.Task7.V2.Lib;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        string d = "C:\\nn\\";
        string nam = "InPutDataFileTask7V2.txt";
        string path = Path.Combine(d, nam);
        string di = "C:\\nn\\";
        string namm = "OutPutDataFileTask7V2.txt";
        string save = Path.Combine(d, nam);
        save = ds.LoadDataAndSave(path);
        Console.WriteLine(save);
        Console.ReadKey();
    }
}