// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Таблица кубов от 1 до {num}");
Console.WriteLine("Число\tКуб");

for (int i = 1; i <= num; i++)
{
    double cube = Math.Pow(i, 3);
    Console.WriteLine($"{i}\t{cube}");
}

