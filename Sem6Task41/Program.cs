// Задача №41.
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Метод cчитывает данные
string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine();
}

// Метод проверяет количество чисел больше 0 и выводит результат
void CheckPositive(string[] arr)
{
    int count = 0;
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (int.Parse(arr[i]) > 0)
        {
            count++;
        }
    }
   Console.WriteLine("Количество чисел больше нуля равно: " + count);
}


//запускаем программу
string nums = ReadData("Введите числа через запятую");
string[] numbers = nums.Split(new char[] { ',' });
CheckPositive(numbers);
// 

