using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint5.Task6.V8.Lib;

namespace Tyuiu.KonevIA.Sprint5.Task6.V8.Test;

[TestClass]
public class DataServiceTest
{
    private static void Check(string content, int expected)
    {
        string path = Path.GetTempFileName();
        try
        {
            File.WriteAllText(path, content);
            Assert.AreEqual(expected, new DataService().LoadFromDataFile(path));
        }
        finally { File.Delete(path); }
    }

    [TestMethod]
    public void CountsTwoCharacterWords()
    {
        Check("Он и мы на уроке. Ты, он!", 5);
    }

    [TestMethod]
    public void HandlesWhitespaceAndPunctuation()
    {
        Check("  to\tbe\r\nor, not; to be!  ", 5);
    }

    [TestMethod]
    public void EmptyAndLongWordsReturnZero()
    {
        Check("", 0);
        Check("я тест программа", 0);
    }
}
