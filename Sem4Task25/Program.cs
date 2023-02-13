// Задача №25.
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//Метод для считывания данных от пользователя
int ReadData(string msg1)
{
  Console.WriteLine(msg1);
  return int.Parse(Console.ReadLine() ?? "0 ");
}
//Метод для вывода результата
void PrintData(string msg2, int res)
{
  Console.WriteLine(msg2 + res);
}

//Метод для возведения числа в степень
int Pow(int a, int b)
{
  int res = 1;
  while (b > 0)
  {
    b = b - 1;
    res = res * a;
  }
  return res;
}
// Считываем данные пользователя
int numA = ReadData("Введите число A: ");
int numB = ReadData("Введите число B: ");

//Запускаем метод по возведению в степень
int result = Pow(numA, numB);

//Выводим результат пользователю
PrintData("Число А в степени В равно ", result);