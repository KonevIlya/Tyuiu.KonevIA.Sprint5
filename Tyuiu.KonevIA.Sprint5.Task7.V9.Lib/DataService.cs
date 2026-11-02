using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KonevIA.Sprint5.Task7.V9.Lib;

public class DataService : ISprint5Task7V9
{
    public string LoadDataAndSave(string path)
    {
        var result = new StringBuilder();
        foreach (char symbol in File.ReadAllText(path))
        {
            if (symbol < 'A' || symbol > 'Z')
                result.Append(symbol);
        }
        string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V9.txt");
        File.WriteAllText(outputPath, result.ToString());
        return outputPath;
    }
}
