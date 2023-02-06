//У нас есть график, где даны отрезок 1 - (х1; x2) и отрезок 2 (х3, x4)
//Необходимо составить код, который находит их пересечение.
//Пересечением двух отрезка 1 и 2 могут быть - отрезок, точка или ничего
//С клавиатуры вводим х1, x2, х3, x4 и выводим ответ 
//- границы пересечений отрезков, общую точку или «не пересекаются».

Console.WriteLine("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x3: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x4: ");
int x4 = Convert.ToInt32(Console.ReadLine());
if (x2 < x3 || x4 <x1)
{
   Console.WriteLine (" не пересекаются"); 
}
else if()
{
    Console.WriteLine (" общая точка"); 
}
else
{
  Console.WriteLine (" пересекается");   
}