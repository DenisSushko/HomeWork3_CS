/*Задача 21 - HARD необязательная
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве.
Сначала задается N с клавиатуры, потом задаются координаты точек.*/

int GetN()
{
    Console.WriteLine("Enter dimension: ");
    int N = int.Parse(Console.ReadLine()!);
    return N;
}

int[] GetCoords(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = int.Parse(Console.ReadLine()!);
    }
    return arr;
}

double GetDistance(int[] arrA, int[] arrB)
{
    int sum = 0;
    for (int i = 0; i < arrA.Length; i++)
    {
        sum += (arrB[i] - arrA[i]) * (arrB[i] - arrA[i]);
    }
    double dist = Math.Sqrt(sum);
    return Math.Round(dist, 3);

}

int N = GetN();
int[] arrayA = new int[N];
Console.WriteLine("Enter coords for point A: ");
arrayA = GetCoords(arrayA);
int[] arrayB = new int[N];
Console.WriteLine("Enter coords for point B: ");
arrayB = GetCoords(arrayB);
double distance = GetDistance(arrayA, arrayB);
Console.WriteLine($"Distance between points: {distance}");
