// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5   7    -2    -0,2
// 1    -3,3   8    -9,9
// 8     7,8  -7,1   9

double[,] CreateMatrix(int rowCount, int columnCount)
{
    double[,] array = new double[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().NextDouble() * new Random().Next(-9,10);
        }
    }
    return array;
}

void PrintMatrix(double[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{Math.Round(array[row, column],1)}\t");
        }
        Console.WriteLine();
    }
}

double[,] matrix = CreateMatrix(3, 4);
PrintMatrix(matrix);
