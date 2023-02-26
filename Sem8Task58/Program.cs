//Задача №58.
//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
//Метод находит произведение двух матриц
int[,] MultMatrix(int[,] matrixA, int[,] matrixB)
    {       
        int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;

                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        return matrixC;
    }
//Запускаем программу
int rowA = ReadData("Введите количество строк матрицы А: ");
int columnA = ReadData("Введите количество столбцов матрицы А: ");
int rowB = ReadData("Введите количество строк матрицы B: ");
int columnB = ReadData("Введите количество столбцов матрицы B: ");

if (columnA == rowB)//Проверяем можно ли перемножить матрицы и выводим ответ
{
    int[,] arrayA = Gen2DArray(rowA, columnA);
    int[,] arrayB = Gen2DArray(rowB, columnB);
    Console.WriteLine("Матрица A");
    Print2DArray(arrayA);
    Console.WriteLine();
    Console.WriteLine("Матрица B");
    Print2DArray(arrayB);
    Console.WriteLine();
    int[,] multArray = MultMatrix(arrayA, arrayB);
    Console.WriteLine("Произведение матриц А и В");
    Print2DArray(multArray);
}
else
{
  Console.WriteLine("Матрицы перемножить нельзя!");
}