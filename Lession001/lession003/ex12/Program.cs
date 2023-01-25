//Задача №17.
//Напишите программу, 
//которая принимает на вход 
//координаты точки (X и Y), 
//причем X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости,
//в которой находится эта точка.

Console.WriteLine("Введите координату Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("определить четверть невозможно");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("первая четверть плоскости");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("четвертая четверть плоскости");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("третья четверть плоскости");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("вторая четверть плоскости");
}