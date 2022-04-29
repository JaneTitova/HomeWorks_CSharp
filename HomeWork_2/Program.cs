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
*/
int FindThirdDigit(int n)
{
    int dig = 0;
    if (n > 99 && n < 1000) dig = n % 10;
    else if (n > 999) dig = (n / 100) % 10;
    else dig = -1;

    return dig;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int digit = FindThirdDigit(num);

if (digit == -1) Console.WriteLine(num + " -> третьей цифры нет");
else Console.WriteLine(num + " -> " + digit);

