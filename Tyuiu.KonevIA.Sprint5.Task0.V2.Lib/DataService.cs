using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KonevIA.Sprint5.Task0.V2.Lib;

public class DataService : ISprint5Task0V2
{
    public string SaveToFileTextData(int x)
    {
        double result = Math.Round(Math.Exp(x) / x, 3);
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
        File.WriteAllText(path, result.ToString(CultureInfo.InvariantCulture));
        return path;
    }
}
