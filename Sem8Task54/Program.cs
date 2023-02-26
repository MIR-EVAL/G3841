//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// Метод генерирует двумерный массив
int[,] Gen2DArray(int row, int column)
{
  int[,] arr = new int[row, column];
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(1, 10);
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

//Метод сортирует строки двумерного массива по убыванию 
void Sort2DArray(int[,] arr)
{
  int[] bufArr = new int[arr.GetLength(1)];
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      bufArr[j] = arr[i, j];
    }
    for (int j = 0; j < bufArr.Length; j++)
    {
      int max = 0;
      for (int n = j + 1; n < bufArr.Length; n++)
      {
        if (bufArr[n] > bufArr[j])
        {
          max = bufArr[n];
          bufArr[n] = bufArr[j];
          bufArr[j] = max;
        }
      }
    }
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = bufArr[j];
    }
  }

}

// запускаем программу
int row = ReadData("Введите количество строк массива: ");
int column = ReadData("Введите количество столбцов массива: ");
int[,] matrix = Gen2DArray(row, column);
Print2DArray(matrix);
Console.WriteLine(); //отступаем строку между исходным и отсортированным массивами
Sort2DArray(matrix);
Print2DArray(matrix);