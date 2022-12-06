// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1,7 -> такого элемента в массиве нет

Console.WriteLine("Введите координаты элемента массива:");
Console.WriteLine("Введите номер строки:");
int numberrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца:");
int numbercolumns = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine("|");
    }
}
bool СoordinatesElement(int[,] matrix, int i, int j)
{
    if (i <= matrix.GetLength(0) && j <= matrix.GetLength(1) && i > 0 && j > 0)
         return true;
    else return false;
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
bool coordinatesElement = СoordinatesElement(array2D, numberrows, numbercolumns);
Console.Write($"{numberrows},{numbercolumns} -> ");
Console.WriteLine(coordinatesElement ? array2D[numberrows - 1, numbercolumns - 1] : "Такого элемента в массиве нет");