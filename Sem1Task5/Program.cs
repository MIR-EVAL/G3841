// Задача №5.
//Написать программу, принимающую на вход число n и выдающую на выходе
//все числа подряд от -n до n.

//Просим пользователя ввести число
Console.Write("Введите число: ");
//Считываем данные с консоли
string? inputNum = Console.ReadLine();
//Проверяем, чтобы данные не были пустыми
if (inputNum != null)
{
  //Парсим введенное число
  int numberA = int.Parse(inputNum);
  // //Вариант 1
  // //Находим соответствующее отрицательное число
  // int numberB = numberA*(-1);
  // //Находим выходные значения
  // string resultLine = string.Empty;

  // while(numberB < numberA)
  // {
  //   resultLine = resultLine + numberB + ",";
  //   numberB = numberB + 1; 

  // resultLine = resultLine + numberA;

  // //Выводим данные в консоль
  // Console.WriteLine(resultLine);

  //Вариант 2 
  for (int i = 0; i < numberA * 2; i++)
  {
    Console.Write(i - numberA);
    Console.Write(", ");
  }
  Console.Write(numberA);
}