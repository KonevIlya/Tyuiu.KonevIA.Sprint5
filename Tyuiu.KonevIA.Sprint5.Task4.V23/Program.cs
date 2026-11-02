using System.Globalization;
using Tyuiu.KonevIA.Sprint5.Task4.V23.Lib;

namespace Tyuiu.KonevIA.Sprint5.Task4.V23;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #5 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #5");
        Line("Тема: Чтение данных из текстового файла");
        Line("Задание #4");
        Line("Вариант #23");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Прочитать x из файла, вычислить y = x^(-3) + 2 + cos(x).");
        Line("Округлить результат до трёх знаков после запятой.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V0.txt");
        Console.WriteLine($"Путь к файлу (Enter — {path}):");
        string enteredPath = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(enteredPath))
            path = enteredPath.Trim().Trim('"');
        if (!File.Exists(path))
        {
            Console.WriteLine("Файл не найден. Скопируйте файл из архива варианта и укажите его путь.");
            Console.ReadLine();
            return;
        }
        Console.WriteLine($"x = {File.ReadAllText(path).Trim()}");
        double result = new DataService().LoadFromDataFile(path);
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(result.ToString(CultureInfo.GetCultureInfo("ru-RU")));
        Console.ReadLine();
    }
}
