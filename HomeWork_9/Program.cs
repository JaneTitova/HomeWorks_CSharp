// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void SumBetweenTwoNums1(int m, int n, int sum)
{
    if(m<=n) 
    {
        //sum+=m;
        SumBetweenTwoNums1(m+1, n, sum+m);
    }
    else Console.WriteLine("1-ая задача. Моё решение " + sum);
}

int SumBetweenTwoNums2(int m, int n)
{
    if(m==n+1) return 0;
    else return m + SumBetweenTwoNums2(m+1, n);
}


SumBetweenTwoNums1(4, 8, 0);
SumBetweenTwoNums1(1, 15, 0);
Console.WriteLine("1-ая задача. Решение как на лекции. Сумма чисел между 4 и 8 = " + SumBetweenTwoNums2(4, 8));
Console.WriteLine("1-ая задача. Решение как на лекции. Сумма чисел между 1 и 15 = " + SumBetweenTwoNums2(1, 15));


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumOfDigits(int n)
{
    if(n == 0) return 0;
    else return n%10 + SumOfDigits(n/10);
}
Console.WriteLine("2-ая задача. Число 45 - " + SumOfDigits(45));
Console.WriteLine("2-ая задача. Число 453 - " + SumOfDigits(453));

