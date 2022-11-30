/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

System.Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(System.Console.ReadLine()!);
System.Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(System.Console.ReadLine()!);

if (num1 > num2)
{
    System.Console.Write("Первое число ");
    System.Console.Write(num1);
    System.Console.Write(" больше второго числа ");
    System.Console.Write(num2);
}
else
{
    System.Console.Write("Второе число ");
    System.Console.Write(num2);
    System.Console.Write(" больше первого числа ");
    System.Console.Write(num1);
}