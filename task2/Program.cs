// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите Xa первой точки: ");
int xa = int.Parse(Console.ReadLine());
Console.Write("Введите Ya первой точки: ");
int ya = int.Parse(Console.ReadLine());
Console.Write("Введите Za второй точки: ");
int za = int.Parse(Console.ReadLine());
Console.Write("Введите Xb второй точки: ");
int xb = int.Parse(Console.ReadLine());
Console.Write("Введите Yb второй точки: ");
int yb = int.Parse(Console.ReadLine());
Console.Write("Введите Zb второй точки: ");
int zb = int.Parse(Console.ReadLine());
int c = (xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (za - zb) * (za - zb);
double e = Math.Sqrt(c);
Console.WriteLine(e);