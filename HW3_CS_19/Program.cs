/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом. Через строку решать нельзя.
14212 -> нет
12821 -> да
23432 -> да*/

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
    int temp1 = num / 10000;
    int temp2 = num % 10;
    int temp3 = (num / 1000) % 10;
    int temp4 = (num % 100) / 10;
    if (temp1 == temp2 && temp3 == temp4)
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
if (count == 5)
{
    IsPalindrome(num, count);
}
else
{
    Console.WriteLine($"{num} - НЕ пятизначное");
}

