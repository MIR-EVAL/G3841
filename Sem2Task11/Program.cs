// Задача №11.
//Наишите программу, которая выводит случайное трехзначное число
//и удаляет вторую цифру этого числа.

//Вариант 1

System.Random numSintezator = new System.Random();

int rndNum = numSintezator.Next(100, 1000);

Console.WriteLine("Случайное число " + rndNum);

int digitFirst = rndNum/100;
int digitLast = rndNum%10;

// //Выводим данные в консоль

//Console.WriteLine("Новое число: " + digitFirst + digitLast);

// //или

//Console.WriteLine(digitFirst + "" + digitLast);

// //или

Console.WriteLine(digitFirst*10 + digitLast);

//Вариант 2 (Через массив)

// System.Random random = new System.Random();

// int randomNumber = random.Next(100,1000);

// Console.WriteLine("число: " + randomNumber);

// string value = randomNumber.ToString();

// char[] numberArray = value.ToCharArray();

// Console.WriteLine(numberArray[0] + "" + numberArray[2]);