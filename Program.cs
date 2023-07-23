// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
//  int first = int.Parse(Console.ReadLine()!);
//  Console.Write("Введите второе число: ");
//  int second = int.Parse(Console.ReadLine()!);
//  if (first>second)
//  {
//  Console.Write ("Большее число =");   
//  Console.WriteLine( first );
// }
//  else
//   Console.WriteLine($"Большее число = {second}");

//Задача 2:  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// int first = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int second = int.Parse(Console.ReadLine()!);
// Console.Write("Введите третье число: ");
// int third = int.Parse(Console.ReadLine()!);
// int max= first;

// if (max<first) max=first;
// if (max<second) max=second;
// if (max<third) max=third;

// Console.Write ("max= ");
// Console.WriteLine (max);

// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли 
// оно на два  без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// int num= number % 2;
// if (num== 0)
// {
//  Console.WriteLine("Четное");
//  }
//  else Console.WriteLine("Нечетное");


// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int num2= 1;

while (num2 <= number) {
    if (num2%2==0)
   
    Console.Write($"{num2}");
     num2++;
} 
    
