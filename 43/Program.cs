// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double getSlope(string userInformation)
{
    Console.Write(userInformation);
    double slope = Convert.ToInt32(Console.ReadLine());
    return slope;
}

double getIntersectionX(double k1, double b1, double k2, double b2)
{
    double X = (b2 - b1) / (k1 - k2);
    return X;
}

double getIntersectionY(double k1, double b1, double k2, double b2)
{
    double Y = k2 * (b2 - b1) / (k1 - k2) + b2;
    return Y;
}

Console.WriteLine("Введите угловые коэффициенты: ");
double slopeB1 = getSlope("b1: ");
double slopeK1 = getSlope("k1: ");
double slopeB2 = getSlope("b2: ");
double slopeK2 = getSlope("k2: ");

double intersectionX = getIntersectionX(slopeK1, slopeB1, slopeK2, slopeB2);
double intersectionY = getIntersectionY(slopeK1, slopeB1, slopeK2, slopeB2);

Console.Write("Точка пересечения прямых: ");
Console.WriteLine($"({intersectionX}; {intersectionY})");
