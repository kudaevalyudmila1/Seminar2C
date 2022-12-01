//  Пользователь вводит с клавиатуры M чисел. 
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа, разделяя их пробелом. В конце ввода нажмите Enter:");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
}

int PositivNumbersCount(int[] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            n++;
    }
    return n;
}
PrintArray(arr);
int positivNumbersCount = PositivNumbersCount(arr);
Console.Write($" -> {positivNumbersCount}");