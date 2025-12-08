using System.Globalization;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MitrofanovaPV.Sprint5.Task5.V30.Lib
{
    public class DataService : ISprint5Task5V30
    {
        public double LoadFromDataFile(string path)
        {




            string content = File.ReadAllText(path);
            string[] tokens = content.Split(new char[] { ' ', '\t', '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries);
            List<string> ohn = new List<string>();
            foreach (string token in tokens)
            {
                if (double.TryParse(token.Replace('.', ','), out double number) && number == 2)
                {
                    ohn.Add(token);
                }

                
            }
            return 2;
        }
    }
}
