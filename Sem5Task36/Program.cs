// Задача №36.
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//Метод выводит результат
void PrintData(string res)
{
  Console.WriteLine(res);
}

//Метод генерирует массив
int[] Gen1DArray(int len, int minValue, int maxValue)
{
  int[] arr = new int[len];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next(minValue, maxValue + 1);
  }
  return arr;
}

//Метод выводит массив
void Print1DArr(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ", ");
  }
  Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Метод считает сумму элементов массива, стоящих на нечётных позициях
int SumPos(int[] arr)
{
  int res = 0;

  for (int i = 1; i < arr.Length; i = i + 2)

    res += arr[i];

  return res;

}

//запускаем программу (обращаемся к методам)
int[] testArr = Gen1DArray(5, -5, 20);
Print1DArr(testArr);
int count = SumPos(testArr);
PrintData("Cумма элементов, стоящих на нечётных позициях, равна :" + count);