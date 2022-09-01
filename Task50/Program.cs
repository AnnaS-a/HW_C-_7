// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4             
// 1, 7 -> такого элемента в массиве нет

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

void ExistenceElement(int[,] matrix)
{
    Console.WriteLine("Введите номер строки искомого элемента");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца искомого элемента");
    int b = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (a == i + 1 && b == j + 1) Console.WriteLine($"в строке {a} столбце {b} находится {matrix[(a - 1), (b - 1)]}");
        }
    }
    if (a > matrix.GetLength(0) || b > matrix.GetLength(1)) Console.WriteLine($"по строке {a} столбцу {b} элемента в массиве нет");
}
int[,] array2D = CreateMatrixRndInt(3, 5, -9, 9);
PrintMatrix(array2D);
ExistenceElement(array2D);

