using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint5.Task3.V6.Lib;

namespace Tyuiu.KonevIA.Sprint5.Task3.V6.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GivenValueSavedAsBinaryDouble()
    {
        string path = new DataService().SaveToFileTextData(3);
        Assert.AreEqual(Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin"), path);
        Assert.AreEqual(8L, new FileInfo(path).Length);
        using var reader = new BinaryReader(File.OpenRead(path));
        Assert.AreEqual(0.866, reader.ReadDouble());
    }

    [TestMethod]
    public void AnotherValueOverwritesFile()
    {
        var service = new DataService();
        service.SaveToFileTextData(3);
        string path = service.SaveToFileTextData(1);
        Assert.AreEqual(8L, new FileInfo(path).Length);
        using var reader = new BinaryReader(File.OpenRead(path));
        Assert.AreEqual(0.707, reader.ReadDouble());
    }
}
