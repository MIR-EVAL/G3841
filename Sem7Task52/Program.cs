//Задача №52.
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
//метод для нахождения среднего арифметического
double[] MeanColumn(int[,] arr)
{
    double[] meanArray = new double[arr.GetLength(1)];
    for(int i = 0; i < arr.GetLength(1); i++)
    {
        for(int j = 0; j < arr.GetLength(0); j++)
        {
            meanArray[i] += arr[j, i]; 
        }
        meanArray[i] = Math.Round(meanArray[i]/arr.GetLength(0), 4);
    }
    return meanArray;
}

//метод для вывода одномерного массива из средних арифметических
void Print1DArray(double[] arr)
{
        for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
}

//запускаем программу
int rows = ReadData("Введите число строк: ");
int columns = ReadData("Введите число столбцов: ");
int[,] array = Gen2DArray(rows, columns);
Print2DArray(array);
double[] meanValues = MeanColumn(array);

Console.WriteLine(); //отступаем строку

Print1DArray(meanValues);
