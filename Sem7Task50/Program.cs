//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод генерирует двумерный массив
int[,] Gen2DArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
    return arr;
}

//Метод выводит двумерный массив на экран
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}
//Метод поиска элемента в массиве
void SearchElement(int[,] arr, int element)
{
    bool elementFind = false;
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == element)
            {
                Console.WriteLine("Данный элемент находится в " + i + " строке, " + j + " столбце");
                elementFind = true;
            }
        }
    }
    if(elementFind == false)
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
}

//Запускаем программу (обращаемся к методам)
int rows = ReadData("Введите число строк: ");
int columns = ReadData("Введите число столбцов: ");
int[,] array = Gen2DArray(rows, columns);
Print2DArray(array);
int elementFind = ReadData("Какое значение элемента массива Вы хотите найти?");
SearchElement(array, elementFind);