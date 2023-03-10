// Задача №43.
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных
//уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//Метод читает данные от пользователя
double ReadData(string msg)
{
    Console.WriteLine(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}


//Метод выводит результат пользователю
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

double b1 = ReadData("Введите b1: ");
double k1 = ReadData("Введите k1: ");
double b2 = ReadData("Введите b2: ");
double k2 = ReadData("Введите k2: ");

//Проверяем, пересекаются ли прямые и находим точку их пересечения

if (k1 == k2)
{
    Console.WriteLine("Прямые не пересекаются!");
}

else

{
    double x = (b2 - b1) / (k1 - k2);
    double y = (b2 * k1 - b1 * k2) / (k1 - k2);

    PrintData("Точка пересечения прямых: (" + x + ", " + y + (')'));
    
}

