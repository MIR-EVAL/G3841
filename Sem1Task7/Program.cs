﻿// Задача №7.
//Напишите программу, которая на входе принимает трехзначное число
//и на выходе и на выходе показывает последнюю цифру этого числа.

//Просим пользователя ввести число
Console.Write("Введите трехзначное число: ");

//Считываем данные с консоли
string? inputNum = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if (inputNum != null)
{
  //Парсим введенное число
  int number = int.Parse(inputNum);

  //Находим последнюю цифру введенного числа
  int lastDigit = number % 10;

  //Выводим данные в консоль
  Console.WriteLine(lastDigit);
}