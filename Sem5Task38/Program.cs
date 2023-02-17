//Задача №38.
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

//Метод выводит результат
void PrintData(string res)
{
  Console.WriteLine(res);
}

//Метод генерирует массив
double[] Gen1DArr(int len, int minValue, int maxValue)
{
  double[] arr = new double[len];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next(minValue, maxValue + 1);
  }
  return arr;
}

void Print1DArr(double[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ", ");
  }
  Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Метод находит разницу между максимальным и минимальным элементами массива
double MinMax(double[] arr)
{
  double max = int.MinValue;
  double min = int.MaxValue;

  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
  }
  return (max - min);
}
//Запускаем программу (обращаемся к методам)
double[] difMaxFromMin = Gen1DArr(10, 1, 100);
Print1DArr(difMaxFromMin);
double conveArr = MinMax(difMaxFromMin);
PrintData("Разница между максимальным и минимальным элементами массива равна: " + conveArr);