using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint5.Task7.V9.Lib;

namespace Tyuiu.KonevIA.Sprint5.Task7.V9.Test;

[TestClass]
public class DataServiceTest
{
    private static void Check(string content, string expected)
    {
        string path = Path.GetTempFileName();
        try
        {
            File.WriteAllText(path, content);
            string outputPath = new DataService().LoadDataAndSave(path);
            Assert.AreEqual(Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V9.txt"), outputPath);
            Assert.AreEqual(expected, File.ReadAllText(outputPath));
            Assert.AreEqual(content, File.ReadAllText(path));
        }
        finally { File.Delete(path); }
    }

    [TestMethod]
    public void RemovesOnlyUppercaseLatinLetters()
    {
        Check("AbC xyz Z ЯЁé 123!", "b xyz  ЯЁé 123!");
    }

    [TestMethod]
    public void PreservesWhitespaceAndLineBreaks()
    {
        Check("AB\r\ncd\tEF\nЯ", "\r\ncd\t\nЯ");
    }

    [TestMethod]
    public void EmptyAndAllUppercaseFiles()
    {
        Check("", "");
        Check("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "");
    }
}
