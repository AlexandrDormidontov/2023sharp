//Задача 27: Напишите программу, 
//которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int SumNum(int A)
{
int count = 1;
int y = A;
while (y / 10 != 0)
 {
    count++;
    y = y / 10;
 }
    return count;
}
Console.WriteLine($"Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

int i = SumNum(A);
int sum = A % 10;
int x = A;
for (int j = 0; j < i; j++)
{
    x = x / 10;
    sum = sum + (x % 10);
}
Console.WriteLine($"Сумма цифр в чиcле {A} = {sum}");


