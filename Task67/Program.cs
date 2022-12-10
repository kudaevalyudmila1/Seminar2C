// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите  число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = Math.Abs(number);

int SumNumbrs(int num)
{
    if(num == 0) return 0;
    return num % 10 + SumNumbrs(num / 10);
}
int result = SumNumbrs(number1);
Console.WriteLine($"{number} -> {result}");