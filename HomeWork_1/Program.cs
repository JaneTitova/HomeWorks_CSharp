/* Задача 1. Напишите программу, которая на вход принимает два числа и выдает, 
какое число больше, а какое меньше.


Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1==number2)
{
    Console.WriteLine("Числа равны");
}
else
{
    if(number1 > number2) Console.WriteLine("Число "+ number1 + " больше, чем число "+ number2);
    if(number1 < number2) Console.WriteLine("Число "+ number2 + " больше, чем число "+ number1);
}

Задача 2. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
1-ый вариант:

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    if (number1 > number3)
    {
        Console.WriteLine(number1 + " самое большое число.");
    }
    else
    {
        Console.WriteLine(number3 + " самое большое число.");
    }
}
else
{
    if(number2 > number3)
    {
        Console.WriteLine(number2 + " самое большое число.");
    }
    else
    {
        Console.WriteLine(number3 + " самое большое число.");
    }
}

2-ой вариант:

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.WriteLine(max + " самое большое число.");

Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) Console.WriteLine(number + " - четное число.");
else Console.WriteLine(number + " - нечетное число.");

Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/
Console.Write("Введите положительное число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 2;
while (count < number+1)
{
    Console.Write(count + ", ");
    count+=2;
}
if (number < 2) Console.WriteLine(number + " меньше или равен 1.");