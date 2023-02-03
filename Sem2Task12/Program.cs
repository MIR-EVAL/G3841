// Задача 12.
//Напишите программу, которая будет принимать на вход два числа
//и выводить, является ли второе число кратным первому.
//Если второе число не кратно первому, то программа выводит остаток от деления.

//Вариант 1.
// //Просим пользователя ввести число №1
// Console.Write("Введите число №1: ");

// //считываем данные с консоли число №1
// string? inputNum1 = Console.ReadLine();

// //Просим пользователя ввести число №2
// Console.Write("Введите число №2: ");

// //считываем данные с консоли число №2
// string? inputNum2 = Console.ReadLine();

// // Проверяем, чтобы данные не были пустыми
// if (inputNum1 != null && inputNum2 != null)
// {
//   // Парсим введенное число №1
//   int number1 = int.Parse(inputNum1);
//   // Парсим введенное число №2
//   int number2 = int.Parse(inputNum2);

//   int remainder = number2%number1;

//   if(remainder==0)
//   {
//     Console.WriteLine("Число №2 кратно числу №1");
//   }

//   else
//   {
//     Console.WriteLine("Число №2 не кратно числу №1: остаток от деления равен " + remainder);
//   }

// }

//Вариант 2.

//Просим пользователя ввести число №1
Console.Write("Введите число №1: ");

//считываем данные с консоли число №1
int number1 = int.Parse(Console.ReadLine()??"0");

//Просим пользователя ввести число №2
Console.Write("Введите число №2: ");

//считываем данные с консоли число №2
int number2 = int.Parse(Console.ReadLine()??"0");

int remainder = number2 % number1;

if (remainder == 0)
{
  Console.WriteLine("Число №2 кратно числу №1");
}

else
{
      Console.WriteLine("Число №2 не кратно числу №1: остаток от деления равен " + remainder);
}

