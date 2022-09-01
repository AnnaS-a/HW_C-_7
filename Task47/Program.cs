// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

double[,] CreateMatrixRndInt(int row, int col, double min, double max)
{
    double[,] matrix = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
    {
            matrix[i,j] = rnd.NextDouble() * (Math.Abs(min- max)) + min;   
    }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    { 
    Console.Write("[");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j < matrix.GetLength(1) -1) Console.Write($"{Math.Round(matrix[i,j],1), 7}");
        else Console.Write($"{Math.Round(matrix[i,j],1), 7}");
    }
    Console.WriteLine("]");
}
}
double[,] array2D = CreateMatrixRndInt(3,4,-9,9);
PrintMatrix (array2D);


