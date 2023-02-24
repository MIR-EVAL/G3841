// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

//Метод для считывания данных от пользователя
int InputNum(string msg)
{
  Console.Write(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод для заполнения двумерного массива
double[,] Gen2DArray(int countRow, int countColumn)
{
  System.Random numberSyntezator = new System.Random();
  int i = 0; int j = 0;
  double[,] outArray = new double[countRow, countColumn];
  while (i < countRow)
  {
    j = 0;
    while (j < countColumn)
    {
      outArray[i, j] = Math.Round((numberSyntezator.Next(-5, 5) + numberSyntezator.NextDouble()),4);
      j++;
    }
    i++;
  }
  return outArray;
}

//метод для печати двумерного массива
void Print2DArray(double[,] inputArray)
{
  int i = 0; int j = 0;

  while (i < inputArray.GetLength(0))
  {
    j = 0;
    while (j < inputArray.GetLength(1))
    {
      Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0, 16));
      
      Console.Write(inputArray[i, j] + " ");
      Console.ResetColor();
      j++;
    }
    
    Console.WriteLine();
    i++;
  }
}

//Получение данных от пользователя
int m = InputNum("Введите количество строк массива: ");
int n = InputNum("Введите количество столбцов массива: ");

//Генерация двумерного массива
double[,] matix = Gen2DArray(m, n);

//Печать двумерного массива
Print2DArray(matix);