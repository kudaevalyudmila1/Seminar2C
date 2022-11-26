﻿// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
bool FindNumber1(int[] array, int num)
{
    bool res = false;
    for (int i = 0; i < array.Length; i++)
    {
        if( array[i] == num) 
        {
            res = true;
            break;
        }
    }
     return res;
}
int[] arr = { 6, 7, 19, 345, 3 };
PrintArray(arr);
bool res = FindNumber1(arr, number);
 Console.Write(res ? " -> Да" : "-> Нет");
