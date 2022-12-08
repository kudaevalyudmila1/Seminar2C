//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixProduct(int[,] matrA, int[,] matrB)
{
    int[,] newarr = new int[matrA.GetLength(0), matrB.GetLength(1)];
    for (int i = 0; i < matrA.GetLength(0); i++)
    {
        for (int j = 0; j < matrB.GetLength(1); j++)
        {
            newarr[i, j] = 0;
            for (int k = 0; k < matrB.GetLength(0); k++)
            {
                newarr[i, j] = newarr[i, j] + matrA [i, k] * matrB[k, j];
            }
       }
   }
    return newarr;
}

int[,] matrixA = CreateMatrixRndInt(2, 4, 1, 9);
int[,] matrixB = CreateMatrixRndInt(4, 3, 1, 9);
PrintMatrix(matrixA);
Console.WriteLine(String.Empty);
PrintMatrix(matrixB);
Console.WriteLine(String.Empty);
if (matrixA.GetLength(1) != matrixB.GetLength(0)) 
Console.WriteLine("Матрицы умножать нельзя");
else {
        int[,] resultmatrix = MatrixProduct(matrixA, matrixB);
        PrintMatrix(resultmatrix);
     }
