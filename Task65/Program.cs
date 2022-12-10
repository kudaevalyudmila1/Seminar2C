// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите первое натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int number2 = Convert.ToInt32(Console.ReadLine());

// мое решение=======
// if (number1 > number2)
// {
//     int temp = number2;
//     number2 = number1;
//     number1 = temp;
// }
// NaturalNumbersMinToMax(number1, number2);

// void NaturalNumbersMinToMax(int num1, int num2)
// {
//     if (num1 == num2 + 1) return;
//     NaturalNumbersMinToMax(num1, num2 - 1);
//     Console.Write($"{num2} ");
// }

 NaturalNumbersMinToMax(number1, number2);

void NaturalNumbersMinToMax(int num1, int num2)
{
    if (num1 > num2 ) 
    {
    NaturalNumbersMinToMax(num1 - 1, num2);
    Console.Write($" {num1} ");
    }
    else if (num1 < num2 )
{
    Console.Write($" {num1} ");
    NaturalNumbersMinToMax(num1 + 1, num2);
}
    else Console.Write($" {num1} ");
}