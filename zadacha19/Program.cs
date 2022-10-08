// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

//Вариант 1: сравнение первого и последнего числа, и второго и четвертого.

Console.WriteLine("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num / 10000;
int num2 = num / 1000 % 10;
int num4 = num % 100 /10;
int num5 = num % 10;

if (num1 == num5 && num2 == num4) Console.WriteLine ($"Число {num} является палиндромом");
else Console.WriteLine ($"Число {num} НЕ палиндромом");

//Вариант 2: сравнение числа из первых двух чисел и перевернутого из двух последних.

Console.WriteLine("Введите пятизначное число:");
int num0 = Convert.ToInt32(Console.ReadLine());

int num12 = num0 / 1000;
int num45 = num0 % 100;
int num54 = num45 % 10 * 10 + num45 / 10;

if (num12 == num54) Console.WriteLine ($"Число {num0} является палиндромом");
else Console.WriteLine ($"Число {num0} НЕ палиндромом");