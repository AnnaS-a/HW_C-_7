// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("]");
    }
}

double[] AverageElementsCol(int[,] matrix)
{
    int k = 0;
    double[] res = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            res[k] += matrix[i, j];
        }
        res[k] = Convert.ToDouble(Math.Round(res[k] / matrix.GetLength(0), 1));
        k++;
    }
    return res;
}
void PrintArray(double[] array)
{
    if (array == null || array.Length <= 0)
    {
        Console.WriteLine("Массив пуст.");
        return;
    }
    Console.Write($"Среднее арифметическое каждого столбца: {array[0]}; ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write($"{array[array.Length - 1]}");
}

int[,] array2D = CreateMatrixRndInt(3, 5, -9, 9);
PrintMatrix(array2D);
Console.WriteLine();
double[] newres = AverageElementsCol(array2D);
PrintArray(newres);
