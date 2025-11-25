using Tyuiu.MitrofanovaPV.Sprint5.Task3.V13.Lib;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 3;
        
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}
