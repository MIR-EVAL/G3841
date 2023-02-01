// Задача №2.
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Просим пользователя ввести первое число
Console.Write("Введите первое число: ");

//считываем данные с консоли первое число
string? inputNum1 = Console.ReadLine();

//Просим пользователя ввести второе число
Console.Write("Введите второе число: ");

//считываем данные с консоли второе число
string? inputNum2 = Console.ReadLine();

// Проверяем, чтобы данные не были пустыми
if (inputNum1 != null && inputNum2 != null)
{
  // Парсим введенное число 1
  int number1 = int.Parse(inputNum1);
  // Парсим введенное число 2
  int number2 = int.Parse(inputNum2);

  //Находим наибольшее число и выводим данные в консоль
  if (number1 > number2)
  {
    Console.Write("Число ");
    Console.Write(number1);
    Console.Write(" больше числа ");
    Console.Write(number2);
  }
  else
  {
    Console.Write("Число ");
    Console.Write(number2);
    Console.Write(" больше числа ");
    Console.Write(number1);

  }
}