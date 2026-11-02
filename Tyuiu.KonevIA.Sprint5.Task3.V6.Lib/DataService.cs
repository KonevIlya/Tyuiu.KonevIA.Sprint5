using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KonevIA.Sprint5.Task3.V6.Lib;

public class DataService : ISprint5Task3V6
{
    public string SaveToFileTextData(int x)
    {
        double result = Math.Round(x / Math.Sqrt((double)x * x + x), 3);
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
        using (var writer = new BinaryWriter(File.Open(path, FileMode.Create)))
        {
            writer.Write(result);
        }
        return path;
    }
}
