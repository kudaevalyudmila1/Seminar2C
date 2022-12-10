// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число:");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число:");
int numberM = Convert.ToInt32(Console.ReadLine());

int SumNaturalNumbers(int numN, int numM)
{
    if (numN == numM +1) return 0;
    return numN + SumNaturalNumbers(numN + 1, numM);
}

int result = 0;
if (numberN < numberM) result = SumNaturalNumbers(numberN, numberM);
else result = SumNaturalNumbers(numberM, numberN);
Console.WriteLine($" N = {numberN}, M = {numberM} -> {result}");