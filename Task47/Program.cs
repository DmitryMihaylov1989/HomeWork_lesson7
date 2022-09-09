// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int line = 3;
int col = 4;
double[,] num = new double[line, col];
Random rnd = new Random();

void CreateMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(rnd.Next(0, 100))/10;
        }
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


CreateMatrix(num);
PrintMatrix(num);
