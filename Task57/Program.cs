//  Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

int[] ReversMatrixToArray(int[,] matrix)
{
    int k = 0;
    int[] arr = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k] = matrix[i, j];
            k++;
        }
    }
    return arr;
}

void PrintResult (int [] array)
{
int count = 1;
int num = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] == num) count++;
    else
    {
        Console.WriteLine($"{num}  встречается {count} раз");
        num = array[i];
        count = 1;
    }
}
Console.WriteLine($"{num}  встречается {count} раз");
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine(" ");
int[] array = ReversMatrixToArray(array2D);
Array.Sort(array);
PrintArray(array);
PrintResult (array);