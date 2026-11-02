using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KonevIA.Sprint5.Task4.V23.Lib;

public class DataService : ISprint5Task4V23
{
    public double LoadFromDataFile(string path)
    {
        string text = File.ReadAllText(path).Trim().Replace(',', '.');
        double x = double.Parse(text, CultureInfo.InvariantCulture);
        return Math.Round(Math.Pow(x, -3) + 2 + Math.Cos(x), 3);
    }
}
