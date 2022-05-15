// Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
void Exponenta(int a, int b)
{
    int expo = 1;
    for(int i=0; i < b; i++) expo*=a;
    Console.Write(expo);
}

Console.WriteLine("Программа возводит число А в степень В.");
Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

Exponenta(numA, numB);
*/
// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
int SummOfDigits(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum+=n%10;
        n/=10;
    } 
    return sum;
}

Console.WriteLine("Программа принимает на вход число и выдаёт сумму цифр в числе.");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(SummOfDigits(num) + " - сумма цифр.");
*/
// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i=0; i<size; i++)
    {
        array[i] = new Random().Next(min, max+1);
        if(i == size-1) Console.Write(array[i] + " ");
        else Console.Write(array[i] + ", ");
    }

    return array;
}

int[] CreateArrayByPerson(int size)
{
    int[] array = new int[size];
    for(int i=0; i<size; i++)
    {
        Console.Write("Введите "+ (i+1) + " элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("-> [" + array[0]);
    for(int i=1; i<array.Length; i++)
    {
        Console.Write(", " + array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] MyArray = CreateRandomArray(8, 1, 99);
PrintArray(MyArray);
int[] MyNewArray = CreateArrayByPerson(8);
PrintArray(MyNewArray);

// не уверена, что поняла правильно задачу, решила 2 способами, первый - программа сама составляет массив,
// второй - при помощи пользователя.
// если не то имелось введу (мы делаи что-то такое уже) - напишите пожалуйста, переделаю и добавлю к след домашке.