// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row, column]}\t");
        }
        Console.WriteLine();
    }
}

int ThereNumberInMatrix(int[,] matrix, int row, int column)
{
    if ((row < 0 || row >= matrix.GetLength(0)) || (column < 0 || column >= matrix.GetLength(1)))
    {
        Console.WriteLine("Такого элемента нет");
        return -1;
    }
    else
        Console.WriteLine(matrix[row, column]);
    return matrix[row, column];
}

int[,] matrix = CreateMatrix(3, 4, 0, 9);
PrintMatrix(matrix);
ThereNumberInMatrix(matrix, 10, 2);