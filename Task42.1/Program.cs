// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// через массив

int[] BinaryCode(int num)
{
    int num2 = num;
    int count = 0;
    while (num > 0)
    {
        num = num / 2;
        count++;
    }
    int[] arr = new int[count];
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        arr[i] = num2 % 2;
        num2 = num2 / 2;
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
}

Console.WriteLine("Введите  число:");
int number = Convert.ToInt32(Console.ReadLine());
int[] arr = BinaryCode(number);
PrintArray(arr);