using Tyuiu.KonevIA.Sprint5.Task1.V5.Lib;

namespace Tyuiu.KonevIA.Sprint5.Task1.V5;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #5 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #5");
        Line("Тема: Класс File. Запись набора данных в текстовый файл");
        Line("Задание #1");
        Line("Вариант #5");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("F(x) = 5 - 3*x + (1 + sin(x)) / (2*x - 0,5).");
        Line("Таблица на [-5; 5], шаг 1. Округлить до двух знаков.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        int startValue = -5;
        int stopValue = 5;
        Line($"Отрезок: [{startValue}; {stopValue}], шаг 1");
        string path = new DataService().SaveToFileTextData(startValue, stopValue);
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        string[] lines = File.ReadAllLines(path);
        Console.WriteLine("{0,8} | {1,12}", "X", "F(X)");
        for (int i = 0; i < lines.Length; i++)
            Console.WriteLine("{0,8} | {1,12}", startValue + i, lines[i]);
        Console.WriteLine($"Файл сохранён: {path}");
        Console.ReadLine();
    }
}

