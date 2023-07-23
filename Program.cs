// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
//  int first = int.Parse(Console.ReadLine()!);
//  Console.Write("Введите второе число: ");
//  int second = int.Parse(Console.ReadLine()!);
//  if (first>second)
//  {
//  Console.WriteLine( first );
// }
//  else Console.WriteLine(second);

//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int third = int.Parse(Console.ReadLine()!);
int max= first;

if (max<first) max=first;
if (max<second) max=second;
if (max<third) max=third;

Console.Write ("max= ");
Console.WriteLine (max);

