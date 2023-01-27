//Задача 28: Напишите программу, 
//которая принимает на вход число N и 
//выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120


int Proiz(int A)
{
    int pr = 1;
    for (int i = 1; i <= A; i++)
    {
      pr = pr * i;  
    }
    return pr;
}
Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" {A} -> {Proiz(A)}");