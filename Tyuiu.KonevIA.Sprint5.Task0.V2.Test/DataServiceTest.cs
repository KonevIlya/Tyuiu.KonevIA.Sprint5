using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint5.Task0.V2.Lib;

namespace Tyuiu.KonevIA.Sprint5.Task0.V2.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GivenValueSavedToTextFile()
    {
        string path = new DataService().SaveToFileTextData(3);
        Assert.AreEqual(Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt"), path);
        Assert.IsTrue(File.Exists(path));
        Assert.AreEqual("6,695", File.ReadAllText(path));
        Assert.AreEqual(6.695, double.Parse(File.ReadAllText(path), CultureInfo.GetCultureInfo("ru-RU")), 1e-12);
    }

    [TestMethod]
    public void AnotherValueOverwritesFile()
    {
        var service = new DataService();
        service.SaveToFileTextData(3);
        string path = service.SaveToFileTextData(1);
        Assert.AreEqual("2,718", File.ReadAllText(path));
    }
}


