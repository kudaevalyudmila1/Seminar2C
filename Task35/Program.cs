//  В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
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

int FindNumberElements (int[] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9  && array[i] < 100)
        n = n + 1;
    }
    return n;
}

int[] arr = CreateArrayRndInt(123, 0, 200);
PrintArray(arr);
int findNumberElements = FindNumberElements(arr);
 Console.WriteLine($"Количество элементов в отрезке [10,99] = {findNumberElements}");