using Tyuiu.MitrofanovaPV.Sprint5.Task2.V1.Lib;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[,] mtr = new int[3, 3] { {6,9,4 }, {7,2,4 }, {4,8,3 } };
        int rows = mtr.GetUpperBound(0) +1;
        int col = mtr.Length / rows;
        string res = ds.SaveToFileTextData(mtr);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}

