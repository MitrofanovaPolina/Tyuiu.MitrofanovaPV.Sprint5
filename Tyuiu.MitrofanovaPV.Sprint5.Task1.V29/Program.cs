using Tyuiu.MitrofanovaPV.Sprint5.Task1.V29.Lib;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int startvalue = -5;
        int stopvalue = 5;
        string res = ds.SaveToFileTextData(startvalue,stopvalue);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}
