using Tyuiu.KonevIA.Sprint5.Task3.V6.Lib;

namespace Tyuiu.KonevIA.Sprint5.Task3.V6;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #5 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #5");
        Line("Тема: Потоковая запись данных в бинарный файл");
        Line("Задание #3");
        Line("Вариант #6");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Вычислить y = x / sqrt(x^2 + x) при x = 3. Округлить до трёх знаков.");
        Line("Сохранить в OutPutFileTask3.bin и вывести на консоль.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        int x = 3;
        Line($"x = {x}");
        string path = new DataService().SaveToFileTextData(x);
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        using (var reader = new BinaryReader(File.OpenRead(path)))
            Console.WriteLine(reader.ReadDouble().ToString(System.Globalization.CultureInfo.GetCultureInfo("ru-RU")));
        Console.WriteLine($"Файл сохранён: {path}");
        Console.ReadLine();
    }
}

