//Задача №8.
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//Просим пользователя ввести число
Console.Write("Введите число: ");

//Считываем данные с консоли
string? inputNum = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if (inputNum != null)
{
  //Парсим введенное число
  int number = int.Parse(inputNum);

  //Определяем выходные значения
  string resultLine = string.Empty;

  for (int i = 2; i < number; i = i + 2)
  {
    resultLine = resultLine + i + ",";
  }

  if (number % 2 == 0)
  {
    resultLine = resultLine + number;
  }

  //Выводим данные в консоль
  Console.WriteLine(resultLine);
}
