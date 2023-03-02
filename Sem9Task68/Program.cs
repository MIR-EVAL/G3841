// //Задача №68.
// // Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// // Даны два неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 9
// // m = 3, n = 2 -> A(m,n) = 29

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

//Метод выводит результат
void PrintResult(long prefix)
{
    Console.WriteLine(prefix);
}

// функция Аккермана с помощью рекурсии
int Ackerman(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    if (numM != 0 && numN == 0)
    {
        return Ackerman(numM - 1, 1);
    }
    if (numM > 0 && numN > 0)
    {
        return Ackerman(numM - 1, Ackerman(numM, numN - 1));
    }
    return Ackerman(numM, numN);
}

//Запускаем программу:
//задаем исходные данные
int numM = ReadData("Введите число m:");
int numN = ReadData("Введите число n:");

//проверяем, что введенные данные больше 0 и выводим результат
if (numM > 0 && numN > 0)
{
    int result = Ackerman(numM, numN);
    PrintResult(result);
}
else
{
Console.WriteLine("Введено отрицательное число!");
}