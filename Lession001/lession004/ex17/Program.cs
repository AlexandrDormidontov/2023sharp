//24) Напишите программу, которая 
//принимает на вход число (А) и 
//выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

int Sum(int A)
{
    int count = A;
    int sum = 0;
    for (int i = 0; i <= A; i++) 
    {   
        sum = sum + i;
    } 
    return sum;
}
Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" {A} -> {Sum(A)}");


