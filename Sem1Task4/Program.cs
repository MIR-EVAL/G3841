// Задача №4.
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//Просим пользователя ввести число №1
Console.Write("Введите число №1: ");

//считываем данные с консоли число №1
string? inputNum1 = Console.ReadLine();

//Просим пользователя ввести число №2
Console.Write("Введите число №2: ");

//считываем данные с консоли число №2
string? inputNum2 = Console.ReadLine();

//Просим пользователя ввести число №3
Console.Write("Введите число №3: ");

//считываем данные с консоли число №3
string? inputNum3 = Console.ReadLine();

// Проверяем, чтобы данные не были пустыми
if (inputNum1 != null && inputNum2 != null && inputNum3 != null)
{
  // Парсим введенное число №1
  int number1 = int.Parse(inputNum1);
  // Парсим введенное число №2
  int number2 = int.Parse(inputNum2);
  // Парсим введенное число №3
  int number3 = int.Parse(inputNum3);

  //Находим наибольшее число и выводим данные в консоль
  if (number1 > number2)
  {
    if (number1 > number3)
    {
      Console.WriteLine("Число №1 наибольшее из трех введенных чисел");
    }
    else
    {
      Console.WriteLine("Число №3 наибольшее из трех введенных чисел");
    }
  }
  else
  {
    if (number2 > number3)
    {
      Console.WriteLine("Число №2 наибольшее из трех введенных чисел");
    }
    else
    {
      Console.WriteLine("Число №3 наибольшее из трех введенных чисел");
    }
  }
}
