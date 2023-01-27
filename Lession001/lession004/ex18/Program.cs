//Задача 26: Напишите программу, 
//которая принимает на вход число и 
//выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

int Count (int number)
{
    int count = 0;
    while (number > 0)
    {
       number = number / 10;
       count = count + 1; 
    }  
    return count;
}
Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" {A} -> {Count(A)}");