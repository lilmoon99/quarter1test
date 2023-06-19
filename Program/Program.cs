/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

System.Console.WriteLine("Choose the variation of task: ");
System.Console.WriteLine("1 - Enter strings from keyboard");
System.Console.WriteLine("2 - Use default arrays");
System.Console.WriteLine("Your choice: ");
int choice = int.Parse(Console.ReadLine());
int charsLessOrEqual = 3;


switch (choice)
{
    case 1:
        System.Console.WriteLine("Enter a number of strings in your line: ");
        int length = int.Parse(Console.ReadLine());
        System.Console.WriteLine($"Enter {length} strings and then press ENTER.");
        string[] array = Console.ReadLine().Split(',', ' ', '/', '.');
        Print(array);
        break;
    case 2:
        string[] array1 = { "Hello", "2", "world", ":-)" };
        string[] array2 = { "1234", "1567", "-2", "computer science" };
        string[] array3 = { "Russia", "Denmark", "Kazan" };
        Print(array1);
        Print(array2);
        Print(array3);
        break;
    default:
        break;
}
// string[] array1 = { "Hello", "2", "world", ":-)" };
// System.Console.WriteLine(newArrayLengthCalculator(array1));
// System.Console.WriteLine($"[{String.Join(',', array1)}] -> [{String.Join(',', newArraySorter(array1))}]");




int newArrayLengthCalculator(string[] line)
{
    int resultLength = 0;
    for (int i = 0; i < line.Length; i++)
    {
        if (line[i].Length <= charsLessOrEqual)
        {
            resultLength++;
        }
    }
    return resultLength;
}

string[] newArraySorter(string[] line)
{
    string[] result = new string[newArrayLengthCalculator(line)];
    int index = 0;
    for (int i = 0; i < line.Length; i++)
    {
        if (line[i].Length <= charsLessOrEqual)
        {
            result[index] = line[i];
            index++;
        }
    }
    return result;
}

void Print(string[] array)
{
    System.Console.WriteLine($"[{String.Join(',', array)}] -> [{String.Join(',', newArraySorter(array))}]");
}

