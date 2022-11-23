// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите  натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

int ProductNumbers(int num)
{
    int prod = 1;
    for (int i = 1; i <= num; i++)
    {
        prod = prod * i;
    }
    return prod;
}
if (number > 0)
{
    int productNumbers = ProductNumbers(number);
    Console.WriteLine($"{number} -> {productNumbers}");
}
else Console.WriteLine("Требуется ввести натуральное число:");