using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KonevIA.Sprint5.Task5.V3.Lib;

public class DataService : ISprint5Task5V3
{
    public double LoadFromDataFile(string path)
    {
        double sum = 0;
        string[] values = File.ReadAllText(path).Split(
            new[] { ' ', '\t', '\r', '\n', ';' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string text in values)
        {
            double value = double.Parse(text.Replace(',', '.'), CultureInfo.InvariantCulture);
            if (value == Math.Truncate(value))
                sum += value;
        }
        return Math.Round(sum, 3);
    }
}
