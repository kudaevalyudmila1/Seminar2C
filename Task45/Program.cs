//  Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

 
int[] CopyArray(int[] massive)
{
    int[] newArray = new int[massive.Length];
    for (int i = 0; i < massive.Length; i++)
    {
        newArray[i] = massive[i];
    }
    return newArray;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int[] arr = { 5, 4, 6, 7 };
int[] newArr = CopyArray(arr);
newArr[0] = 99;
PrintArray(arr);
Console.WriteLine();
PrintArray(newArr);

