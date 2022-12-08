﻿// // Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndInt1(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
    int matr = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = matr + 1;
                matr++;
            }
        }
    }
    return matrix;
}
void PrintMatrix1(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($" {matrix[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

int[,,] matrix3D = CreateMatrixRndInt1(2, 2, 2);
PrintMatrix1(matrix3D);
