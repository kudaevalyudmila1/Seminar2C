// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]



Console.WriteLine("Введите  размер массива:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  минимальное значение рандомного числа:");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  максимальное значение рандомного числа:");
int maximum = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
void FillArray(int[] arr, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
}
void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} ");
        if (i == arr.Length - 1) Console.Write(" ");
        else Console.Write(",");
    }
    Console.Write("]");
}
FillArray(array, minimum, maximum);
PrintArray(array);