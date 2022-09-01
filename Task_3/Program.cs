// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void FindAverageColumn(int[,] matrix)
{
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        double sum = 0;
        double average = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            sum += matrix[row,column];
        }  
        average = sum / matrix.GetLength(0);
        Console.Write($"{Math.Round(average, 1)}\t");
    }
}

int[,] matrix = CreateMatrix(3, 4, 0, 9);
PrintMatrix(matrix);
FindAverageColumn(matrix);