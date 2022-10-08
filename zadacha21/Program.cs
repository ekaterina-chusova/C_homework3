// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
 
Console.Clear();

Console.WriteLine("Введите координаты первой точки x, y и z: ");
int[] point1 = new int[3];
point1[0] = Convert.ToInt32(Console.ReadLine());
point1[1] = Convert.ToInt32(Console.ReadLine());
point1[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки x, y и z: ");
int[] point2 = new int[3];
point2[0] = Convert.ToInt32(Console.ReadLine());
point2[1] = Convert.ToInt32(Console.ReadLine());
point2[2] = Convert.ToInt32(Console.ReadLine());

double sum = 0;

for (int i = 0; i < point1.Length; i++)
{
    for (i = 0; i < point2.Length; i++)
    {
        double sum1 = Math.Pow(point1[i]-point2[i], 2);
        sum = sum + sum1;
    }
}

Console.WriteLine(sum);
double distance = Math.Round(Math.Sqrt(sum), 2);
Console.WriteLine($"Расстояние между точками равно {distance}");