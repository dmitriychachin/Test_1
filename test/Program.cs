/*
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
        Console.WriteLine($"Введите элемент №{i + 1}");

        array[i] = Console.ReadLine();
    }

    return array;
}

//Составление нового массива элементы, которого не длинее 3 символов
string[] sortedArray(string[] array)
{
    string[] sortedArray = new string[array.Length];

    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sortedArray[j] = array[i];
            j += 1;
        }
        else;
    }
    return sortedArray;
}



//Печать массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int x = GetNumber("Введите количество элементов в массиве");
string[] firstArray = createArray(x);
Console.WriteLine();
Console.WriteLine("Вы ввели этот массив");
PrintArray(firstArray);
string[] sortArray = sortedArray(firstArray);
Console.WriteLine();
Console.WriteLine("Получился массив:");
PrintArray(sortArray);