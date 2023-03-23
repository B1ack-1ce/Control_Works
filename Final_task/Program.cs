Console.Clear();
Console.WriteLine("Контрольная задача.");
Console.WriteLine($"Вывести слова, которые имеют не больше 3-х символов.\n");

string[] arr = { "Value", "Var", "Task", "SW", "Int", "GB", "" };

ShowArray(arr, "Исходный массив:");

SortArray(arr);

Console.ReadKey();

void SortArray(string[] arr) //Сортировка массива
{
    string[] finalArr = new string[arr.Length];
    for (int i = 0, j = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            finalArr[j] = arr[i];
            j++;
        }
    }
    ShowArray(finalArr, "Результат:");
}

void ShowArray(string[] arr, string msg = "") //Вывод массива
{
    Console.WriteLine(msg);
    foreach (var item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}