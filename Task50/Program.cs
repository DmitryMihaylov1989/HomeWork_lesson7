//  Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//  значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("введите номер строки(в диапазоне от 1 до 10)");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца(в диапазоне от 1 до 10) ");
int b = Convert.ToInt32(Console.ReadLine());
int [,] num = new int [10,10];
Random rnd = new Random();
FillArrayRandomNumbers(num);

if (a > num.GetLength(0) || b > num.GetLength(1))
{
    Console.WriteLine("такого элемента в массиве не существует (вне диапазона)");
}
else
{
    Console.WriteLine($"элемент равен {num[a-1,b-1]}");
    Console.WriteLine();
}

PrintArray(num);

void FillArrayRandomNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i, j] = Convert.ToInt32(rnd.Next(0, 100));
            }   
        }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}