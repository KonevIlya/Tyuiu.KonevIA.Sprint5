using Tyuiu.KonevIA.Sprint5.Task0.V2.Lib;

namespace Tyuiu.KonevIA.Sprint5.Task0.V2;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #5 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #5");
        Line("Тема: Класс File. Запись данных в текстовый файл");
        Line("Задание #0");
        Line("Вариант #2");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Вычислить y = e^x / x при x = 3. Округлить до трёх знаков.");
        Line("Сохранить в OutPutFileTask0.txt и вывести на консоль.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        int x = 3;
        Line($"x = {x}");
        string path = new DataService().SaveToFileTextData(x);
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(File.ReadAllText(path));
        Console.WriteLine($"Файл сохранён: {path}");
        Console.ReadLine();
    }
}
