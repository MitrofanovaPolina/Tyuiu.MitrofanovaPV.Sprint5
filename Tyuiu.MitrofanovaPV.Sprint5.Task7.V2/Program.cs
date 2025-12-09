using Tyuiu.MitrofanovaPV.Sprint5.Task7.V2.Lib;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        
        string path = "C:/DataSprint5/InPutDataFileTask7V2.txt";
        
        
        Console.WriteLine(ds.LoadDataAndSave(path));
        Console.ReadKey();
    }
}