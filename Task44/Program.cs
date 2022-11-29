Console.WriteLine("Введите   число:");
int num = Convert.ToInt32(Console.ReadLine());

int [] array = new int [num];
int[] ArrayFibonacci(int n)
{
    array[1] = 1;
    for (int i = 2; i < n; i++)
    {
        array[i] = array[i-1] + array[i-2];
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
    Console.Write("]");
}
int[] arr = ArrayFibonacci(num);
PrintArray(arr);