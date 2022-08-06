// Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.


using System;
using static System.Console;

Clear();

WriteLine("Введите количество слов в массиве: ");
int count = int.Parse(ReadLine());
if (count <= 0)
{
    WriteLine("Ошибка. Число слов не может быть <= 0");
    return;
}
WriteLine("Введите содержание массива (слова): ");
string arrayStr = "";
string[] mainArray = GetArrayString(arrayStr, count);
string[] selectedElements = SelectShortStrings(mainArray);
Write($"[\"{String.Join("\", \"", mainArray)}\"] -> [\"{String.Join("\", \"", selectedElements)}\"]");


string[] GetArrayString(string ArrStr, int NumberOfWords)
{
    string[] result = new string[NumberOfWords];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = ReadLine();
    }
    return result;
}

int CountNumber(string[] ArrStr)
{
    int count = 0;
    for (int i = 0; i < ArrStr.Length; i++)
    {
        if (ArrStr[i].Length < 4)
        {
            count += 1;
        }
    }
    return count;
}

string[] SelectShortStrings(string[] ArrStr)
{
    int j = 0;
    string[] result = new string[CountNumber(ArrStr)];
    for (int i = 0; i < ArrStr.Length; i++)
    {
        if (ArrStr[i].Length < 4)
        {
            result[j] = ArrStr[i];
            j++;
        }
    }
    return result;
}

