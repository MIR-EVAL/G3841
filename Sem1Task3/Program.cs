// Задача №3.
// Вывести название дня недели, соответствующее введенному числу.


//Просим пользователя ввести число, соответствующее дню недели
Console.Write("Введите порядковый номер дня недели:");
//Считываем данные с консоли
string? inputNum = Console.ReadLine();
//Проверяем, чтобы данные не были пустыми
if(inputNum!=null)
{

  //Парсим введенное число
  int Dayname = int.Parse(inputNum);

//Вариант 1
//   //Выводим сообщение об ошибке, если число больше 7
//   if(Dayname > 7)
//   {
//     Console.WriteLine("Номер не соответствует дню недели!");
//   }

//   else
//   {
//   //Создаем массив с днями недели
//   string[] Weekday = new string[7];
//   Weekday[0] = "понедельник";
//   Weekday[1] = "вторник";
//   Weekday[2] = "среда";
//   Weekday[3] = "четверг";
//   Weekday[4] = "пятница";
//   Weekday[5] = "суббота";
//   Weekday[6] = "воскресенье";

//   //Находим название дня недели по введенному числу
//   string Weekdayname = Weekday[Dayname-1];

//   //Выводим данные в консоль
//   Console.WriteLine(Weekdayname);
//   }


//Вариант 2

string Weekdayname = string.Empty;
switch(Dayname)
{

  case 1: Weekdayname = "понедельник"; break;
  case 2: Weekdayname = "вторник"; break;
  case 3: Weekdayname = "среда"; break;
  case 4: Weekdayname = "четверг"; break;
  case 5: Weekdayname = "пятница"; break;
  case 6: Weekdayname = "суббота"; break;
  case 7: Weekdayname = "воскресенье"; break;
  default: Weekdayname = "Это не день недели!"; break;

}

Console.WriteLine(Weekdayname);

}