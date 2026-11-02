using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KonevIA.Sprint5.Task6.V8.Lib;

public class DataService : ISprint5Task6V8
{
    public int LoadFromDataFile(string path)
    {
        int count = 0;
        foreach (Match word in Regex.Matches(File.ReadAllText(path), @"\b[\p{L}\p{N}]+\b"))
        {
            if (word.Length == 2)
                count++;
        }
        return count;
    }
}
