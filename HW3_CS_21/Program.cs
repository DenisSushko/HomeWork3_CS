/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int[] GetCoords(int[] arr)
{
    for (int i = 0; i < 3; i++)
    {
        arr[i] = int.Parse(Console.ReadLine()!);
    }
    return arr;
}

double GetDistance(int[] arrA, int[] arrB)
{
    int sum = 0;
    for (int i = 0; i < 3; i++)
    {
        sum += (arrB[i] - arrA[i]) * (arrB[i] - arrA[i]);
    }
    double dist = Math.Sqrt(sum);
    return Math.Round(dist, 2);
}

int[] arrayA = new int[3];
int[] arrayB = new int[3];
Console.WriteLine("Введите координаты точки А");
arrayA = GetCoords(arrayA);
Console.WriteLine("Введите координаты точки В");
arrayB = GetCoords(arrayB);

double distance = GetDistance(arrayA, arrayB);
Console.WriteLine($"Расстояние = {distance}");

