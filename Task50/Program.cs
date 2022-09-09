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
int [,] numbers = new int [10,10];
Random rnd = new Random();
FillArrayRandomNumbers(numbers);

if (a > numbers.GetLength(0) || b > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента в массиве не существует (вне диапазона)");
}
else
{
    Console.WriteLine($"элемент равен {numbers[a-1,b-1]}");
    Console.WriteLine();
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i, j] = Convert.ToInt32(rnd.Next(0, 100));
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}