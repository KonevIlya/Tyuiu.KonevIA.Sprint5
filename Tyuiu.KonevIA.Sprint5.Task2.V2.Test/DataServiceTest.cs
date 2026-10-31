using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint5.Task2.V2.Lib;

namespace Tyuiu.KonevIA.Sprint5.Task2.V2.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GivenMatrixSavedAsCsv()
    {
        string path = new DataService().SaveToFileTextData(new int[,]
        {
            {-7,7,5}, {4,2,-7}, {2,6,-4}
        });
        Assert.AreEqual(Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv"), path);
        CollectionAssert.AreEqual(new[] {"0;1;1", "1;1;0", "1;1;0"}, File.ReadAllLines(path));
    }

    [TestMethod]
    public void ZeroAndRectangularMatrix() =>
        CollectionAssert.AreEqual(new[] {"0;0;1"},
            File.ReadAllLines(new DataService().SaveToFileTextData(new int[,] {{0,-2,3}})));
}
