// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов 
// в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int Prompt(string message)
{
    System.Console.WriteLine($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillArray(int m)
{
    int[,] matr = new int[m, m];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }

    }
    return matr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]}  ");
        }
        System.Console.WriteLine();

    }
}

int[] StringMinSum(int[,] arr)
{
    int sum = 0;
    int[] SumArray = new int[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        SumArray[i] = sum;
    }
    return SumArray;
}
int FoundString(int[] arr)
{
    int minI = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < arr[minI])
        {
            minI = i;
        }
    }
    return minI+1;
}

int m = Prompt("Введи количество строк прямоугольного массива");
int[,] array = FillArray(m);
PrintArray(array);
int[]arr=StringMinSum(array);
System.Console.WriteLine($"Строка с наименьшей суммой элементов {FoundString(arr)} ");