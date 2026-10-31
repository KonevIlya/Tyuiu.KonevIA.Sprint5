using Tyuiu.KonevIA.Sprint5.Task2.V2.Lib;

namespace Tyuiu.KonevIA.Sprint5.Task2.V2;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #5 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #5");
        Line("Тема: Класс File. Запись структурированных данных");
        Line("Задание #2");
        Line("Вариант #2");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Ввести матрицу 3 на 3. Положительные заменить на 1,");
        Line("отрицательные на 0. Сохранить в OutPutFileTask2.csv.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        int[,] array = new int[3, 3];
        for (int row = 0; row < 3; row++)
            for (int column = 0; column < 3; column++)
            {
                Console.Write($"Элемент [{row + 1}, {column + 1}]: ");
                array[row, column] = Convert.ToInt32(Console.ReadLine());
            }
        string path = new DataService().SaveToFileTextData(array);
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        foreach (string line in File.ReadAllLines(path))
            Console.WriteLine(line.Replace(";", " "));
        Console.WriteLine($"Файл сохранён: {path}");
        Console.ReadLine();
    }
}
