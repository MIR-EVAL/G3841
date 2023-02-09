//Задача №19.
//Напишите программу, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.


//Метод для считывания данных от пользователя
int ReadData(string msg1)
{
    Console.WriteLine(msg1);
    return int.Parse(Console.ReadLine() ?? "0 ");
}
// Метод для вывода результата
void PrintData(string msg2)
{
    Console.WriteLine(msg2);
}
// Метод для проверки на палиндром
bool PalinTest(int num)
{
    bool res = false;
    int d1 = num / 10000;
    int d2 = (num / 1000) % 10;
    int d3 = (num % 100) / 10;
    int d4 = num % 10;
    res = (d1 == d4) && (d2 == d3) ? true : false;

    return res;
}

// Считываем данные пользователя
int num = ReadData("Введите пятизначное число: ");

// Проверяем, является ли число пятизначным
if (num > 9999 && num < 100000)
{
    // Выводим результат пользователю
    if (PalinTest(num) == true)
    {
        PrintData("Это палиндром");
    }
    else
    {
        PrintData("Это не палиндром");
    }
}
else
{
    PrintData("Число не является пятизначным! Введите корректное значение!");
}