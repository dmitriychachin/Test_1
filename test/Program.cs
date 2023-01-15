﻿/*
Написать программу, которая из имеющегося строк формирует массив из строк, 
длинна которых меньше либо равна 3 символа. Первоначальный массив можноввести
с клавиатуры, либо задать на старте выполнения алгоритма.
*/

//функция получения числа с консоли
int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;


    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число или 0. Введите корректное число");
        }
    }

    return result;
}

//Создание массива
string[] createArray(int x)
{
    string[] array = new string[x];

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите элемент №{i}");

        array[i] = Console.ReadLine();
    }

    return array;
}