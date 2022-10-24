/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int GetNumber()
{
    Console.WriteLine("Введите число ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int[] getCubes(int N)
{
    int[] arr = new int[N];
    for (int i = 1; i <= N; i++)
    {
        arr[i - 1] = i * i * i;
    }
    return arr;
}

void printArray(int[] arr, int N)
{
    string str = "Ответ: ";
    for (int i = 0; i < N; i++)
    {
        if (i == N - 1)
        {
            str += arr[i] + ". ";
        }
        else
        {
            str += arr[i] + ", ";
        }
    }
    Console.WriteLine(str);
}

int N = GetNumber();

int[] arr = getCubes(N);

printArray(arr, N);
