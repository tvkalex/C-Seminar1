//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.WriteLine("Введите число: ");
int N = int.Parse(System.Console.ReadLine()!); //Add ! as null forgiving to avoid mistake "Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL." [Ex002_HelloUser]csharp(CS8600)
for (int i = 1; i <= N; i++)
{
    if(i % 2 == 0)
    Console.Write(i + " ");
}

//Решение в одну строчку. Вот к чему нужно стремиться ☺
//foreach (int i in Enumerable.Range(1, int.Parse(Console.ReadLine()) >> 1)) Console.WriteLine(i << 1);
