//Задача 25: Напишите цикл, 
//который принимает на вход 
//два числа (A и B) и возводит 
//число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень в которую надо возвести число: ");
int B = Convert.ToInt32(Console.ReadLine());
int c = 1;
for (int i = 0; i < B; i++)
{
  c = c*A; 
}
Console.Write($"число {A} в степени {B} равно {c}");
