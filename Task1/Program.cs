//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

System.Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(System.Console.ReadLine()!); //Add ! as null forgiving to avoid mistake "Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL." [Ex002_HelloUser]csharp(CS8600)
System.Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(System.Console.ReadLine()!); //Add ! as null forgiving to avoid mistake "Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL." [Ex002_HelloUser]csharp(CS8600)

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

//Решение в одну строчку. Вот к чему нужно стремиться ☺
//Console.WriteLine(Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).Max());