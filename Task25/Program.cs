//  Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243
// 2, 4 -> 16




Console.WriteLine("Введите  число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int GradeNumber(int numa, int numb)
{
    int num = 0;
    int res = 1;
    while (num < numb)
    {
        res = res * numa;
        num++;
    }
    return res;
}
if (numberB > 0)
{
    int gradeNumber = GradeNumber(numberA, numberB);
    Console.WriteLine($"{numberA} , {numberB} -> {gradeNumber} ");
}
else Console.WriteLine("Число B не является натуральным");


