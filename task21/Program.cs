// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату x1: ");
Double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y1: ");
Double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z1: ");
Double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x2: ");
Double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y2: ");
Double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z2: ");
Double z2 = Convert.ToDouble(Console.ReadLine());

double A = x2 - x1;
double B = y2 - y1;
double C = z1 - z2;

Console.WriteLine($"Длинна отрезка {A * A + B * B + C * C}");



