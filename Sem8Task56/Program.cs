//Задача №56ю
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

//Метод находит строку с наименьшей суммой элементов

(int min, int line) MinSum2DArr(int[,] arr)
{
  int min = int.MaxValue;

  int line = 0;

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    int buf = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      buf += arr[i, j];
    }
    if (buf < min)
    {
      min = buf;
      line = i;
    }
  }
  return (min, line);
}

//Метод выводит данные пользователю
void PrintData(string res)
{
  Console.WriteLine(res);
}
//Запускаем программу
int row = ReadData("Введите количество строк массива: ");
int column = ReadData("Введите количество столбцов массива: ");
int[,] matrix = Gen2DArray(row, column);
Print2DArray(matrix);

//Проверяем является ли массив прямоугольником и выводим ответ
if (row != column)
{
  (int buf, int line) minSum = MinSum2DArr(matrix);
  PrintData("Минимальная сумма элементов одной строки равна: " + minSum.buf);
  PrintData("Строка: " + (minSum.line + 1));
}
else
{
  Console.WriteLine("Массив не является прямоугольным!");
}