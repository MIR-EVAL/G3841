//Задача #27.
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//Метод для считывания данных от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
//Метод для вывода результата пользователю
void PrintData(string msg1, int msg2)
{
  Console.WriteLine(msg1);
  Console.WriteLine(msg2);
}

//Метод для нахождения суммы цифр, из которых состоит число
int SumSym(int num)
{
  int res = 0;
  while (num > 0)
  {
    res = res + num % 10;
    num = num / 10;
  }
  return res;
}

//Считываем данные пользователя
int number = ReadData("Введите число: ");

//запускаем метод нахождения суммы цифр
int result = SumSym(number);

//Выводим результат пользователю
PrintData("Сумма цифр в данном числе равна ", result);