using System.Globalization;
using Tyuiu.KonevIA.Sprint5.Task5.V3.Lib;

namespace Tyuiu.KonevIA.Sprint5.Task5.V3;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #5 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #5");
        Line("Тема: Чтение набора данных из текстового файла");
        Line("Задание #5");
        Line("Вариант #3");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Прочитать числа из файла и найти сумму всех целых чисел.");
        Line("Округлить результат до трёх знаков после запятой.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V3.txt");
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
        Console.WriteLine(File.ReadAllText(path));
        double result = new DataService().LoadFromDataFile(path);
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(result.ToString(CultureInfo.GetCultureInfo("ru-RU")));
        Console.ReadLine();
    }
}

