// Определить количество цифр в числе

Console.WriteLine("Введите любое целое число:");
int number = Convert.ToInt32(Console.ReadLine());

int NumberDigit(int num)
{
    int n = 0;
    while (num != 0)
    {
        num = num / 10;
        n++;
    }
    return n == 0 ? 1 : n;
}
int numberDigit = NumberDigit(number);
Console.WriteLine($"Количество  цифр в числе {number} равно  {numberDigit}");



