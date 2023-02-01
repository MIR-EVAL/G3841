// Задача №1.
// Напишите программу, которая на вход принимает два числа 
// и проверяет, является ли первое число квадратом второго.

//считываем данные с консоли 1-е число
string? inputNum1 = Console.ReadLine();
//считываем данные с консоли 2-е число
string? inputNum2 = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if(inputNum1!=null && inputNum2!=null)
{
 // Парсим введенное число 1
  int number1 = int.Parse(inputNum1);
   // Парсим введенное число 2
  int number2 = int.Parse(inputNum2);

  if(number1==number2*number2)
  {
    Console.WriteLine("Первое число квадрат второго!");
  }
  else
  {
    Console.WriteLine("Первое число не квадрат второго!");
  }
}