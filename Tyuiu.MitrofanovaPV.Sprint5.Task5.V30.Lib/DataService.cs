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

            foreach (string token in tokens)
            {
                if (double.TryParse(token.Replace('.', ','), out double number))
                {
                    numbers = (int)(numbers + Convert.ToDouble(token));
                }
            }

            return numbers;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        public static int? FindMaxPrimeInteger(List<double> numbers)
        {
            int? maxPrime = null;

            foreach (double number in numbers)
            {
                // Проверяем, является ли число целым
                if (Math.Abs(number - Math.Round(number)) < 0.0001)
                {
                    int intValue = (int)Math.Round(number);

                    if (IsPrime(intValue))
                    {
                        if (maxPrime == null || intValue > maxPrime)
                        {
                            maxPrime = intValue;
                        }
                    }
                }
            }

            return maxPrime;
        }
    }
}
