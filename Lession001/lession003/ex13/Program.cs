//Напишите программу, 
//которая по заданному номеру четверти, 
//показывает диапазон возможных координат 
//точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int qarter = Convert.ToInt32(Console.ReadLine());
if (qarter == 1)
{
    Console.WriteLine("х - любой положительный, y - любой положительный");
}
else if (qarter == 2)
{
    Console.WriteLine("х - любой положительный, y - любой отрицательный");
}
else if (qarter == 3)
{
    Console.WriteLine("х - любой отрицательный, y - любой отрицательный");
}
else if (qarter == 4)
{
    Console.WriteLine("х - любой отрицательный, y - любой положительный");
}