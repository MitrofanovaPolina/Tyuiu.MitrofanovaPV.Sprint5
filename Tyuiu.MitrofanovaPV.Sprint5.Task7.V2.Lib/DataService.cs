using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MitrofanovaPV.Sprint5.Task7.V2.Lib
{
    public class DataService : ISprint5Task7V2
    {
        public string LoadDataAndSave(string path)
        {
            string save = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V2.txt");
            FileInfo fileInfo = new FileInfo(save);
            bool fileex = fileInfo.Exists;
            if (fileex)
            {
                File.Delete(save);
            }
            string strline = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] == '1') || (line[i] == '2') || (line[i] == '3') || (line[i] == '4') || (line[i] == '5') || (line[i] == '6') || (line[i] == '7') || (line[i] == '8') || (line[i] == '9') || (line[i] == '0'))
                        {
                            
                            strline = strline + '#';
                        }
                        else
                        {
                            strline = strline + line[i];
                        }
                    }
                    File.AppendAllText(save, strline + Environment.NewLine);
                    strline = "";
                }
            }
            return save;
        }
    }
}
