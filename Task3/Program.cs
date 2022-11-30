//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

System.Console.WriteLine("Введите число для проверки на четность(ДА)/нечетность(НЕТ): ");
int num = int.Parse(System.Console.ReadLine()!); //Add ! as null forgiving to avoid mistake "Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL." [Ex002_HelloUser]csharp(CS8600)

if (num % 2 == 0)
{
    System.Console.WriteLine("ДА");
}
else
{
    System.Console.WriteLine("НЕТ");
}

//Решение в одну строчку. Вот к чему нужно стремиться ☺
//Console.WriteLine((int.Parse(Console.ReadLine()) & 1) == 0? "Yes": "No");
//& 1 - побитовая операция "И" в двоичной системе, сравниваем число с единицей,проверяем крайний правый бит на 1 (нечетный), 0 (четный).