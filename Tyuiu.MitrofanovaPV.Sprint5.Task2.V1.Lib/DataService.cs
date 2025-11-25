using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MitrofanovaPV.Sprint5.Task2.V1.Lib
{
    public class DataService : ISprint5Task2V1
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string nam = "OutPutFileTask1.csv";
            string p = Path.Combine(Path.GetTempPath(), nam);
            FileInfo fileInfo = new FileInfo(p);
            bool fileex = fileInfo.Exists;
            if (fileex)
            {
                File.Delete(p);

            }
            int rows = matrix.GetUpperBound(0)+1;
            int col = matrix.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i,j]%2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            string str = "";
            for (int i = 0;i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j != col -1)
                    {
                        str = str + matrix[i,j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i,j];
                    }
                }
                if (i != rows - 1)
                {
                    File.AppendAllText(p, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(p, str);
                }
                str = "";

            }
            return p;
        }
    }
}
