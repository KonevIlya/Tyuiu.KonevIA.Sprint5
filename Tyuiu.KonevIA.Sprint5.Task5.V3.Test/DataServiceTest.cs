using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint5.Task5.V3.Lib;

namespace Tyuiu.KonevIA.Sprint5.Task5.V3.Test;

[TestClass]
public class DataServiceTest
{
    private static void Check(string content, double expected)
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
    public void SumsOnlyIntegers()
    {
        Check("2\n-3\n4.5\n6\n0\n-1.25\n", 5);
    }

    [TestMethod]
    public void SupportsDecimalCommaAndSeparators()
    {
        Check(" 2,0; -4,0\t1,5\r\n7.000 2.0004 ", 5);
    }

    [TestMethod]
    public void NoIntegersOrEmptyFileReturnsZero()
    {
        Check("1.5\n-2,75", 0);
        Check("", 0);
    }
}
