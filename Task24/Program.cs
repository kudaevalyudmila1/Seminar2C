// Программа принимает на вход число А.
// Найти сумму чисел от 1 до А.

Console.WriteLine("введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++ )
    {
        sum = sum + i;
    }
    return sum;
}  

int sumNumbers = SumNumbers(number);
Console.WriteLine($"сумма чисел от 1 до {number} = {sumNumbers}");