//Задача 40: Напишите программу, 
//которая принимает на вход три числа 
//и проверяет, может ли существовать 
//треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: 
//каждая сторона треугольника меньше 
//суммы двух других сторон

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine($"треугольник со сторонами {a}, {b}, {c} может существовать");
}
else
{
    Console.WriteLine($"треугольника со сторонами {a}, {b}, {c} - быть не может");
}
   