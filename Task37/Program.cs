// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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

int[] ArrayComposition(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 == 1) size += 1;
    int[] arrComp = new int[size];
    for (int i = 0; i < arrComp.Length; i++)
    {
        if (i != arr.Length - 1 - i)
        {
            arrComp[i] = arr[i] * arr[arr.Length - 1 - i];
        }
        else arrComp[i] = arr[i];
    }
    return arrComp;
}
int[] arr = CreateArrayRndInt(7, 1, 10);
PrintArray(arr);
int[] arrComp = ArrayComposition(arr);
PrintArray(arrComp);