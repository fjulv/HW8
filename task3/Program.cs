//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 1 | 3 4
// 3 2 1 | 3 3
// _ _ _ | 1 1
// Результирующая матрица будет:
// 19 21
// 16 19

int Prompt(string message)
{
    System.Console.WriteLine($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillArray(int m, int n)
{
    int[,] matr = new int[m, n];
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

int[,] MultArray(int[,] arrOne, int[,] arrTwo)
{
    int[,] mult = new int[arrOne.GetLength(0), arrTwo.GetLength(1)];

    for (int i = 0; i < mult.GetLength(0); i++)
    {

        for (int j = 0; j < mult.GetLength(1); j++)
        {
            int sum = 0;

            for (int k = 0; k < arrOne.GetLength(1); k++)
            {
                sum += arrOne[i, k] * arrTwo[k, j];
                mult[i, j] = sum;
            }
        }
    }
    return mult;
}


int a = Prompt("Введи количество строк первого массива");
int b = Prompt("Введи количество столбцов первого массива");
int c = Prompt("Введи количество строк второго массива");
int d = Prompt("Введи количество столбцов второго массива");

if (b != c)
{
    System.Console.WriteLine("Поизведение матриц найти невозможно, количество столбцов первой матрицы должно быть равно количеству строк второй матрицы");
}
else
{
    int[,] arrayOne = FillArray(a, b);
    int[,] arrayTwo = FillArray(c, d);
    System.Console.WriteLine("Первый массив:");
    PrintArray(arrayOne);
    System.Console.WriteLine("Второй массив:");
    PrintArray(arrayTwo);
    System.Console.WriteLine("Произведение двух матриц:");
    int[,] arrayMulty = MultArray(arrayOne, arrayTwo);
    PrintArray(arrayMulty);
}