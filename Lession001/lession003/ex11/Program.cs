//изучаем массивы
string f1 = "Anna";
string f2 = "Bob";
string f3 = "Alex";
string f4 = "Ira";
string f5 = "Mila";

//string [] f;
string[] f = { f1, f2, f3, f4, f5 };
//int[] = num;
//int num = new int[5];// запись массива из 5 чисел
//int num = {1, 2, 3, 4, 5};// здесь та же самая запись из 5 чисел

int[] num = { 1, 2, 3, 4, 5 }; // таже самая запись, ошибкой не будет

Console.WriteLine(f[4]);

f[1] = "Roman";
Console.WriteLine(f[1]);
Console.WriteLine(f.Length);

for (int i = 0; i < f.Length; i++)
{
    Console.WriteLine(f[i]);
}
// цикл foreach нужен чтобы перебирать массив
//он находит число в массиве или выводит весь массив.
//в этом цикле нельзя менять данные
foreach (int n in num)
{
    Console.WriteLine(n);
}

//цикл может выводить например не весь массив (убрали Boba)
//также он ищет четные числа и т.д.
foreach (string n in f)
{
    if (n != "Bob")
        Console.WriteLine(n);
}

//еще нужная формула про извлечение квадратного корня
double num = Math.Sqrt(x);

//нужная для решения задач формула возведения в степень
double num = Math.Pow(x, 3);//здесь Х - это число, 3 это степень в которую возводим