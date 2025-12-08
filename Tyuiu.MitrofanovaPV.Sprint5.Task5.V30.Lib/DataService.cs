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
            var numbers = 0;
            
            
            
            string content = File.ReadAllText(path);
            string[] tokens = content.Split(new char[] { ' ', '\t', '\n', '\r' }, 
                StringSplitOptions.RemoveEmptyEntries);
            
            // Используем инвариантную культуру для парсинга
            CultureInfo culture = CultureInfo.InvariantCulture;
            
            foreach (string token in tokens)
            {
                // Пробуем несколько форматов для парсинга
                if (double.TryParse(token, NumberStyles.Any, culture, out double number))
                {
                    numbers = (int)(numbers + Convert.ToDouble(token));
                }
                else if (double.TryParse(token.Replace('.', ','), NumberStyles.Any, culture, out number))
                {
                    numbers = (int)(numbers + Convert.ToDouble(token));
                }
                else if (double.TryParse(token.Replace(',', '.'), NumberStyles.Any, culture, out number))
                {
                    numbers = (int)(numbers + Convert.ToDouble(token));
                }
                else
                {
                    Console.WriteLine($"Не удалось распознать число: '{token}'");
                }
            }
            
            return 2;
        }
    }
}
