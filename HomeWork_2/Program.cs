/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

int FindSecondDigit(int n)
{
    int dig = (n/10)%10;
    return dig;
}

Console.WriteLine("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    int digit = FindSecondDigit(num);
    Console.Write("-> "+ digit);
}
else Console.Write("Это не трехзначное число");

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

int FindThirdDigit(int n)
{
    int dig = n % 10;
    return dig;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int digit = 0;

Console.Write(num + " -> ");

if (num > 99 && num < 1000)
{
    digit = FindThirdDigit(num);
    Console.Write(digit);
}
else if (num > 999) 
{
    while(num > 1000) num = num/10;
    digit = FindThirdDigit(num);
    Console.Write(digit);
}
else Console.Write("третьей цифры нет");

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
bool IsItWeekend(int n)
{
    bool d = false;
    if(n==6 || n==7) d = true;
    return d;
}

Console.Write("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day > 0 && day < 8) 
{
    bool weekend = IsItWeekend(day);
    if(weekend)  Console.Write(day + " -> да");
    else Console.Write(day + " -> нет");
}
else Console.Write(day + " -> таких дней недели нет");

