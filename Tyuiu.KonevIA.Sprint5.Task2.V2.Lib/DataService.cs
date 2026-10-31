using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KonevIA.Sprint5.Task2.V2.Lib;

public class DataService : ISprint5Task2V2
{
    public string SaveToFileTextData(int[,] array)
    {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
        var lines = new List<string>();
        for (int row = 0; row < array.GetLength(0); row++)
        {
            var values = new string[array.GetLength(1)];
            for (int column = 0; column < array.GetLength(1); column++)
            {
                array[row, column] = array[row, column] > 0 ? 1 : 0;
                values[column] = array[row, column].ToString();
            }
            lines.Add(string.Join(";", values));
        }
        File.WriteAllLines(path, lines);
        return path;
    }
}
