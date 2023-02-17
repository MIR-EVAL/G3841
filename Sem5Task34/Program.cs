//Задача №34. 
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//(сделала на основе массива из 10 чисел)

//Метод выводит результат
void PrintData(string res)
{
    Console.WriteLine(res);
}

//Метод генерирует массив
int[] Gen1DArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

//Метод выводит массив
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Метод считает количество четных чисел в массиве
int CountElem(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Test(arr[i]))
        {
            res++;
        }
    }
    return res;
}

//Метод тестирует числа массива на четность
bool Test(int n)
{
    return (n%2==0);
}

//запускаем программу (обращаемся к методам)
int[] testArr = Gen1DArray(10,100,999);
Print1DArr(testArr);
int count = CountElem(testArr);
PrintData("Количество четных чисел в массиве :"+count);