//Задача №60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.Write(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// Метод генерирует трехмерный массив
int[,,] Gen3DArray(int x, int y, int z)
{
  int[,,] matrix = new int[x, y, z];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        matrix[i, j, k] = new Random().Next(10, 100);
      }
    }
  }
  return matrix;
}

//Метод выводит трехмерный массив на экран с указанием индекса каждого числа
void Print3DArray(int[,,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        Console.Write(arr[i, j, k] + "(" + i + ", " + j + ", " + k + ")" + "\t");
      }
        Console.WriteLine();
    }
  }
}
//Запускаем программу
int x = ReadData("Введите длину массива (x): ");
int y = ReadData("Введите ширину массива (y): ");
int z = ReadData("Введите высоту массива (z): ");
int[,,] res3DArray = Gen3DArray(x, y, z);
Print3DArray(res3DArray);