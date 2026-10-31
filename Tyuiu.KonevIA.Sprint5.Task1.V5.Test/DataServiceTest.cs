using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint5.Task1.V5.Lib;

namespace Tyuiu.KonevIA.Sprint5.Task1.V5.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GivenTable()
    {
        string path = new DataService().SaveToFileTextData(-5, 5);
        Assert.AreEqual(Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt"), path);
        double[] actual = File.ReadAllLines(path)
            .Select(line => double.Parse(line, CultureInfo.InvariantCulture)).ToArray();
        double[] expected = Enumerable.Range(-5, 11)
            .Select(x => Math.Round(5 - 3.0 * x + (1 + Math.Sin(x)) / (2.0 * x - 0.5), 2)).ToArray();
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SinglePoint() =>
        Assert.AreEqual("3", File.ReadAllText(new DataService().SaveToFileTextData(0, 0)).Trim());
}
