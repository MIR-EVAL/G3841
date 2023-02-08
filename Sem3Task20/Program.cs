//Задача №20.
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

//Метод выводит результат пользователю
void PrintData(string msg, double res)
{
  Console.WriteLine(msg + res);
}

//Метод вычисляет расстояние между точками в 2D пространстве
double CalkLen(int x1, int x2, int y1, int y2)
{
  double res = 0;
  res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
  return res;
}

// //Вводим координаты точек
// int coordX1 = ReadData("Введите координату X1");
// int coordX2 = ReadData("Введите координату X2");
// int coordY1 = ReadData("Введите координату Y1");
// int coordY2 = ReadData("Введите координату Y2");

// //Вызываем метод для вычисления расстояния между точками
// double len = CalkLen(coordX1, coordX2, coordY1, coordY2);

// //Выводим результат
// PrintData("Расстояние между точками: ", len);

//Или объединяем три последних шага в одно действие (но лучше разделять код на логические операции для лучшей читаемости)
PrintData("Расстояние между точками: ", CalkLen(ReadData("Введите координату X1"), ReadData("Введите координату X2"), ReadData("Введите координату Y1"), ReadData("Введите координату Y2")));