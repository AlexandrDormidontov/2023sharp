//21) Напишите программу, которая 
//принимает на вход координаты двух 
//точек и находит расстояние между 
//ними в 2D пространстве.
//
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату х1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату х2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());

double s = Math.Sqrt((Math.Pow(x1 - y1),2) +(Math.Pow(x2 - y2),2));
Console.WriteLine($"расстояние между точками в 2D плоскости = {s}");