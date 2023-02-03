﻿//Задача №16
//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// //Вариант 1.

// //Просим пользователя ввести число №1
// Console.Write("Введите число №1: ");

// //считываем данные с консоли число №1
// int number1 = int.Parse(Console.ReadLine()??"0");

// //Просим пользователя ввести число №2
// Console.Write("Введите число №2: ");

// //считываем данные с консоли число №2
// int number2 = int.Parse(Console.ReadLine()??"0");

// //Сравниваем квадраты чисел с изначальными числами и выводим данные в консоль

// if(number1==number2*number2)
// {
//   Console.WriteLine("Число №1 является квадратом числа №2");
// }

// else
// {
//   if(number2==number1*number1)
//   {
//     Console.WriteLine("Число №2 является квадратом числа №1");
//   }
//   else
//   {
//     Console.WriteLine("Число №1 не является квадратом числа №2, число №2 не является квадратом числа №1");
//   }
// }

//Вариант 2

// Вводим данные с консоли
int num1 = int.Parse(Console.ReadLine() ?? "0");
int num2 = int.Parse(Console.ReadLine() ?? "0");

//сравнение возведённого в квадрат числа с другим числом
TestSQRT(num1,num2);
TestSQRT(num2,num1);

void TestSQRT(int i, int j)
{
    if ((int)Math.Pow(i, 2) == j)
    {
        Console.WriteLine("Число " + j + " является квадратом числа " + i);
    }
    else
    {
        Console.WriteLine("Число " + j + " не является квадратом числа " + i);
    }
}
