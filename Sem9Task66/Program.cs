//Задача №66.
//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

//Метод выводит результат
void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}

//нахождение суммы с помощью рекурсии

int RecSumMN(int numM, int numN)
{
    if (numM >= numN)
    {
        return numN;
    }
    else
    {
        return numM + RecSumMN(numM + 1, numN);
    }
}

//Запускаем программу
int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
int result = numM < numN ? RecSumMN(numM, numN) : RecSumMN(numN, numM);
PrintResult(result);