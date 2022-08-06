// Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.


using System;
using static System.Console;

Clear();

WriteLine("Введите количество слов в массиве: ");
int size = int.Parse(ReadLine());
if (size <= 0)
{
    WriteLine("Ошибка. Число слов не может быть <= 0");
    return;
}
WriteLine("Введите содержание массива: ");
string arrayStr = "";
string[] mainArray = GetArrayString(arrayStr, size);
string[] selectedElements = SelectShortElements(mainArray);
Write($"[\"{String.Join("\", \"", mainArray)}\"] -> [\"{String.Join("\", \"", selectedElements)}\"]");


string[] GetArrayString(string arrStr, int numberOfWords)
{
    string[] result = new string[numberOfWords];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = ReadLine();
    }
    return result;
}

int CountNumberOfShortElem(string[] arrStr)
{
    int count = 0;
    for (int i = 0; i < arrStr.Length; i++)
    {
        if (arrStr[i].Length < 4)
        {
            count += 1;
        }
    }
    return count;
}

string[] SelectShortElements(string[] arrStr)
{
    int j = 0;
    string[] result = new string[CountNumberOfShortElem(arrStr)];
    for (int i = 0; i < arrStr.Length; i++)
    {
        if (arrStr[i].Length < 4)
        {
            result[j] = arrStr[i];
            j++;
        }
    }
    return result;
}

