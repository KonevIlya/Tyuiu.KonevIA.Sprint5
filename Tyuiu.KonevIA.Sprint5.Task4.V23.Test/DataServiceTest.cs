using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint5.Task4.V23.Lib;

namespace Tyuiu.KonevIA.Sprint5.Task4.V23.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ReadsValueAndRoundsResult()
    {
        string path = Path.GetTempFileName();
        try
        {
            File.WriteAllText(path, "3");
            Assert.AreEqual(1.047, new DataService().LoadFromDataFile(path));
        }
        finally { File.Delete(path); }
    }

    [TestMethod]
    public void AcceptsBothDecimalSeparators()
    {
        string path = Path.GetTempFileName();
        try
        {
            foreach (string text in new[] { " 1,5\n", "1.5" })
            {
                File.WriteAllText(path, text);
                Assert.AreEqual(2.367, new DataService().LoadFromDataFile(path));
            }
        }
        finally { File.Delete(path); }
    }
}
