/*Задача 19 - HARD необязательная
Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. 
Через строку нельзя решать само собой.*/

int GetNumber()
{
    Console.WriteLine("Введите число: ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
int countDigits(int numArg)
{
    int count = 1;
    int temp = numArg;
    while (temp > 10)
    {
        temp /= 10;
        count++;
    }
    return count;
}

void IsPalindrome(int num, int count)
{
    bool isP = false;
    int[] arr = new int[count];
    int temp = 0;
    for (int i = 0; i < count; i++)
    {
        if (i == 0)
        {
            arr[i] = (num / Convert.ToInt32(Math.Pow(10, count - i - 1)));
        }
        else
        {
            temp = 0;
            for (int j = 0; j < i; j++)
            {
                temp += arr[j] * Convert.ToInt32(Math.Pow(10, i - j));
            }
            arr[i] = (num / Convert.ToInt32(Math.Pow(10, count - i - 1))) % temp;
        }

    }

    for (int i = 0; i < count / 2; i++)
    {
        if (arr[i] == arr[count - i - 1])
        {
            isP = true;
        }
        else
        {
            isP = false;
            break;
        }
    }

    if (isP)
    {
        Console.WriteLine($"{num} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{num} - НЕ палиндром");
    }
}

int num = GetNumber();
int count = countDigits(num);

IsPalindrome(num, count);
