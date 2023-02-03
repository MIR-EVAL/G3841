// Задача 14.
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

//Просим пользователя ввести число
Console.Write("Введите число: ");

//считываем данные с консоли
int number = int.Parse(Console.ReadLine()??"0");

int res1 = number%7;
int res2 = number%23;

if((res1==0)&&(res2==0))
{
  Console.WriteLine("Число кратно 7 и 23");
}

else
{
  Console.WriteLine("Число некратно 7 и 23");
}