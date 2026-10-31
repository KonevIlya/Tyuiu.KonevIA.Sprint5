using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KonevIA.Sprint5.Task1.V5.Lib;

public class DataService : ISprint5Task1V5
{
    public string SaveToFileTextData(int startValue, int stopValue)
    {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
        var lines = new List<string>();
        for (int x = startValue; x <= stopValue; x++)
        {
            double denominator = 2.0 * x - 0.5;
            double result = denominator == 0 ? 0
                : Math.Round(5 - 3.0 * x + (1 + Math.Sin(x)) / denominator, 2);
            lines.Add(result.ToString(CultureInfo.GetCultureInfo("ru-RU")));
        }
        File.WriteAllLines(path, lines);
        return path;
    }
}

