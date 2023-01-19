//Напишите программу, которая на вход
// принимает одно число (N), а на выходе
// показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("start");
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("найти количество четных чисел от 1 до " + N);

for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
       Console.WriteLine(i++);
    }
}
Console.WriteLine("end");