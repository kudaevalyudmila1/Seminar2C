// Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите параметры первой прямой:");
Console.WriteLine("k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите параметры второй прямой:");
Console.WriteLine("k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("b2:");
double b2 = Convert.ToDouble(Console.ReadLine());

double СoordinatesAbscissa(double ka1, double ka2, double bc1, double bc2)
{
    return (bc2 - bc1) / (ka1 - ka2);
}

double СoordinatesOrdinate(double xd, double ka1, double bc1)
{
    return ka1 * xd + bc1;
}

if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают.");
else if (k1 == k2) Console.WriteLine("Прямые не пересекаются.");
else
{
    double coordinatesAbscissa = СoordinatesAbscissa(k1, k2, b1, b2);
    double coordinatesX = Math.Round(coordinatesAbscissa, 2);
    double coordinatesOrdinate = СoordinatesOrdinate(coordinatesAbscissa, k1, b1);
    double coordinatesY = Math.Round(coordinatesOrdinate, 2);
    Console.Write($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2}");
    Console.Write($" -> ({coordinatesX};{coordinatesY})");
}